using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace BSMS.Winforms.Forms
{
    public partial class TotalSummaryForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DailySummary? TotalSummaryData { get; set; }
        public TotalSummaryForm()
        {
            InitializeComponent();

        }

        private async void TotalSummary_Load(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Today.AddDays(-365);

            DateTime toDate = DateTime.Today;


            await PopulateTotalSummary(fromDate, toDate);
        }

        private async Task PopulateTotalSummary(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var dailySummaries = await GetDailySummaries(fromDate, toDate);
                if (dailySummaries != null && dailySummaries.Any())
                {
                    // Calculate total summary based on daily summaries
                    TotalSummaryData = CalculateTotalSummary(dailySummaries);

                    if (TotalSummaryData != null)
                    {
                        UpdateControls(TotalSummaryData);
                    }
                    else
                    {
                        XtraMessageBox.Show("Unable to calculate total summary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private async Task<IEnumerable<DailySummary>?> GetDailySummaries(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var dailySummaries = await Program.ApiSdk.GetDailySummaries(fromDate, toDate);
                return dailySummaries;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return null;
            }
        }

        private DailySummary? CalculateTotalSummary(IEnumerable<DailySummary>? dailySummaries)
        {
            if (dailySummaries == null)
                return null;

            DailySummary totalSummary = new DailySummary();

            foreach (var summary in dailySummaries)
            {
                totalSummary.TotalGross += summary.TotalGross;
                totalSummary.TotalCash += summary.TotalCash;
                totalSummary.TotalPos += summary.TotalPos;
                // ... Add other aggregation logic here
            }

            return totalSummary;
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

        private void ResetSummary()
        {
            totalGrossEdit.EditValue = 0;
            totalCashEdit.EditValue = 0;
            totalPosEdit.EditValue = 0;
            // ... Reset other controls here
        }

        private async void CalculateTotalSummarybtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var dailyCosts = Functions.NullToDecimal(dailyCostsEdit.EditValue);
                if (dailyCosts < 0)
                {
                    XtraMessageBox.Show("Only values >= 0 allowed for daily costs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dateFrom = DateFrom.DateTime;
                var dateTo = DateTo.DateTime;

                // Fetch daily summaries for the specified date range
                var dailySummaries = await Program.ApiSdk.GetDailySummaries(dateFrom, dateTo);

                if (dailySummaries != null && dailySummaries.Any())
                {
                    // Calculate totals from the fetched daily summaries
                    var totalGross = dailySummaries.Sum(summary => summary.TotalGross);
                    var totalCash = dailySummaries.Sum(summary => summary.TotalCash);
                    var totalPos = dailySummaries.Sum(summary => summary.TotalPos);
                    var totalNet = dailySummaries.Sum(summary => summary.TotalNet);
                    var cashNet = dailySummaries.Sum(summary => summary.TotalCashNet);
                    var dailyCostsTotal = dailySummaries.Sum(summary => summary.DailyCosts);

                    // Update controls
                    totalGrossEdit.EditValue = totalGross;
                    totalCashEdit.EditValue = totalCash;
                    totalPosEdit.EditValue = totalPos;
                    totalNetEdit.EditValue = totalNet;
                    cashNetEdit.EditValue = cashNet;
                    dailyCostsEdit.EditValue = dailyCostsTotal;
                }
                else
                {
                    XtraMessageBox.Show("No daily summaries found for the specified date range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetSummary();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async Task<DailySummary?> CalculateTotalSummary(DateTime dateFrom, DateTime dateTo, decimal dailyCosts)
        {
            var dailySummaries = await GetDailySummaries(dateFrom, dateTo);
            return CalculateTotalSummary(dailySummaries);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private async Task GetDailyOrders(DateTime fromDate, DateTime toDate)
        {
            try
            {
                var orders = await Program.ApiSdk.GetOrders(fromDate, toDate);
                if (orders != null)
                {
                    List<OrderSummary> orderSummaries = new();
                    foreach (var order in orders)
                    {
                        orderSummaries.Add(new OrderSummary
                        {
                            Id = order.OrderId,
                            Date = order.OrderDate,
                            TotalPrice = order.OrderServices?.Sum(service => service.ServicePrice) ?? 0,
                            DiscountedPrice = order.PaymentSummaries?.FirstOrDefault()?.DiscountedPrice ?? 0,
                            TotalPOS = order.PaymentSummaries?.FirstOrDefault()?.TotalPOS ?? 0,
                            TotalCash = order.PaymentSummaries?.FirstOrDefault()?.TotalCash ?? 0,
                            CustomerFullName = order.Customer != null ? $"{order.Customer.SubjectLastName} {order.Customer.SubjectName}" : ""
                            // Set other properties based on your data model
                        });
                    }

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void CalculateDailySumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var dailyCosts = Functions.NullToDecimal(dailyCostsEdit.EditValue);
                if (dailyCosts < 0)
                {
                    XtraMessageBox.Show("Only values >= 0 allowed for daily costs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dateFrom = DateFrom.DateTime;
                var dateTo = DateTo.DateTime;

                // Fetch daily summaries for the specified date range
                var dailySummaries = await Program.ApiSdk.GetDailySummaries(dateFrom, dateTo);

                if (dailySummaries != null && dailySummaries.Any())
                {
                    // Calculate totals from the fetched daily summaries
                    var totalGross = dailySummaries.Sum(summary => summary.TotalGross);
                    var totalCash = dailySummaries.Sum(summary => summary.TotalCash);
                    var totalPos = dailySummaries.Sum(summary => summary.TotalPos);
                    var totalNet = dailySummaries.Sum(summary => summary.TotalNet);
                    var cashNet = dailySummaries.Sum(summary => summary.TotalCashNet);
                    var dailyCostsTotal = dailySummaries.Sum(summary => summary.DailyCosts);

                    // Update controls
                    totalGrossEdit.EditValue = totalGross;
                    totalCashEdit.EditValue = totalCash;
                    totalPosEdit.EditValue = totalPos;
                    totalNetEdit.EditValue = totalNet;
                    cashNetEdit.EditValue = cashNet;
                    dailyCostsEdit.EditValue = dailyCostsTotal;
                }
                else
                {
                    XtraMessageBox.Show("No daily summaries found for the specified date range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetSummary();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSummary();
        }

        private void CalculateSummary()
        {
            // Determine the selected time period
            string selectedTimePeriod = comboBoxEdit1.SelectedItem.ToString();

            DateTime startDate;
            DateTime endDate = DateTime.Today;

            switch (selectedTimePeriod)
            {
                case "Week":
                    startDate = endDate.AddDays(-7);
                    break;
                case "1 Month":
                    startDate = endDate.AddMonths(-1);
                    break;
                case "3 Months":
                    startDate = endDate.AddMonths(-3);
                    break;
                case "6 Months":
                    startDate = endDate.AddMonths(-6);
                    break;
                case "1 Year":
                    startDate = endDate.AddYears(-1);
                    break;
                default:
                    startDate = DateTime.MinValue;
                    break;
            }

        }
    }
}

