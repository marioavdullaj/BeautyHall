using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace BSMS.Winforms.Forms
{
    public partial class DailySummaryForm : FixedRibbonForm
    {
        private DailySummary? DailySummary { get; set; }
        public DailySummaryForm() => InitializeComponent();

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) => Close();

        private async void DailySummaryForm_Load(object sender, EventArgs e)
        {
            summaryDateEdit.DateTime = DateTime.Today;

            await GetDailyOrders(DateTime.Today);
            await GetDailySummary(DateTime.Today);
        }

        private void ResetSummary()
        {
            totalGrossEdit.EditValue = 0;
            totalCashEdit.EditValue = 0;
            totalPosEdit.EditValue = 0;
            totalNetEdit.EditValue = 0;
            cashNetEdit.EditValue = 0;
            dailyCostsEdit.EditValue = 0;
        }

        private async Task GetDailyOrders(DateTime date)
        {
            try
            {
                var orders = await Program.ApiSdk.GetOrders(date, date.AddDays(1));
                if (orders != null)
                {
                    List<OrderSummary> orderSummaries = new();
                    foreach (var x in orders)
                    {
                        orderSummaries.Add(new OrderSummary
                        {
                            Id = x.OrderId,
                            Date = x.OrderDate,
                            TotalPrice = x.OrderServices?.Sum(x => x.ServicePrice) ?? 0,
                            DiscountedPrice = x.PaymentSummaries?.FirstOrDefault()?.DiscountedPrice ?? 0,
                            TotalPOS = x.PaymentSummaries?.FirstOrDefault()?.TotalPOS ?? 0,
                            TotalCash = x.PaymentSummaries?.FirstOrDefault()?.TotalCash ?? 0,
                            CustomerFullName = x.Customer != null ? $"{x.Customer.SubjectLastName} {x.Customer.SubjectName}" : ""
                        });
                    }
                    orderSummaryGridControl.DataSource = orderSummaries;
                }
                else
                {
                    orderSummaryGridControl.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async Task GetDailySummary(DateTime date)
        {
            try
            {
                var s = await Program.ApiSdk.GetDailySummaries(date, date.AddDays(1));
                if (s != null && s.Any())
                {
                    DailySummary = s.First();
                    UpdateControls(DailySummary);
                }
                else
                {
                    ResetSummary();
                    SummaryPanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateControls(DailySummary summary)
        {
            SummaryPanel.Visible = true;
            totalGrossEdit.EditValue = summary.TotalGross;
            totalCashEdit.EditValue = summary.TotalCash;
            totalPosEdit.EditValue = summary.TotalPos;
            totalNetEdit.EditValue = summary.TotalNet;
            cashNetEdit.EditValue = summary.TotalCashNet;
            dailyCostsEdit.EditValue = summary.DailyCosts;
        }

        private async void calculateDailySummaryButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var dailyCosts = Functions.NullToDecimal(dailyCostsEdit.EditValue);
                if (dailyCosts < 0)
                {
                    XtraMessageBox.Show("Only values >= 0 allowed for daily costs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await Program.ApiSdk.CalculateDailySummary(summaryDateEdit.DateTime, dailyCosts);
                if (result != null)
                {
                    DailySummary = result;
                    UpdateControls(DailySummary);
                }
                else
                {
                    XtraMessageBox.Show("It was not possible calculating the daily summary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void summaryDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                await GetDailyOrders(summaryDateEdit.DateTime);
                await GetDailySummary(summaryDateEdit.DateTime);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var dailyCosts = Functions.NullToDecimal(dailyCostsEdit.EditValue);
                if (dailyCosts < 0)
                {
                    XtraMessageBox.Show("Only values >= 0 allowed for daily costs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await Program.ApiSdk.CalculateDailySummary(summaryDateEdit.DateTime, dailyCosts);
                if (result != null)
                {
                    DailySummary = result;
                    UpdateControls(DailySummary);
                }
                else
                {
                    XtraMessageBox.Show("It was not possible calculating the daily summary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}