using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using BSMS.Winforms.GenericUtils;
using DevExpress.XtraRichEdit.UI;
using BSMS.Winforms.Utils;

namespace BSMS.Winforms.Forms
{
    public partial class OrderHistoryForm : FixedRibbonForm
    {
        
        private IEnumerable<Order>? orders;
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            await Reload();
        }

        private async Task Reload()
        {
            orders = await Program.ApiSdk.GetOrders((DateTime)dateFrom.EditValue, (DateTime)dateTo.EditValue);
            grOrders.DataSource = orders?.Select(x => new OrderSummary
            {
                Id = x.OrderId,
                Date = x.OrderDate,
                CustomerFullName = x.Customer != null ? $"{x.Customer.SubjectLastName} {x.Customer.SubjectName}" : "",
                Notes = x.Notes,
                TotalPrice = x.OrderServices?.Sum(x => x.ServicePrice) ?? 0,
                DiscountedPrice = x.PaymentSummaries.FirstOrDefault()?.DiscountedPrice ?? 0,
                TotalPOS = x.PaymentSummaries.FirstOrDefault()?.TotalPOS ?? 0,
                TotalCash = x.PaymentSummaries.FirstOrDefault()?.TotalCash ?? 0,
                Payed = x.PaymentSummaries != null && x.PaymentSummaries.Count() > 0
            });

            SetCheckboxEdit<bool>(grOrders, "Payed", true, false);
        }

        private void grOrders_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = DateTime.Today;
            dateTo.EditValue = DateTime.Today.AddDays(1);
        }

        private async void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var selected = grvOrders.GetSelectedRows();
                if (selected != null && selected.Any())
                {
                    var selectedOrder = orders?.ElementAt(selected[0]);
                    if (selectedOrder != null)
                    {
                        var orderForm = new OrderForm(selectedOrder);
                        orderForm.FormClosed += OrderForm_FormClosed;
                        Program.dashboard.ShowForm(orderForm);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void OrderForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            await Reload();
        }

        private void grvOrders_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            /*
            var selectedRow = e.ControllerRow;
            grvOrders.SelectionChanged -= grvOrders_SelectionChanged;
            foreach (var row in grvOrders.GetSelectedRows())
                if (row != selectedRow)
                    grvOrders.UnselectRow(row);
            grvOrders.SelectionChanged += grvOrders_SelectionChanged;
            */
        }

        private async void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                bool result = true;
                var selectedRows = grvOrders.GetSelectedRows();
                var question = $"Are you sure you wanna delete these {selectedRows.Length} orders?";
                if (XtraMessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var selectedRow in selectedRows)
                    {
                        var selectedOrder = orders?.ElementAt(selectedRow);
                        if (selectedOrder != null)
                        {
                            result = await Program.ApiSdk.DeleteOrder(selectedOrder.OrderId);
                            if (!result)
                                break;
                        }
                    }

                    if (result)
                    {
                        XtraMessageBox.Show("Orders deleted successfully!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("An error occured while deleting the orders", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await Reload();
            }
        }

        private async void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var selectedRows = grvOrders.GetSelectedRows();
                List<Order?> selectedOrders = new();
                
                foreach (var selectedRow in selectedRows)
                {
                    var selectedOrder = orders?.ElementAt(selectedRow);
                    if (selectedOrder != null)
                    {
                        selectedOrders.Add(selectedOrder);
                    }
                }

                DateTime minDate = DateTime.MaxValue;
                DateTime maxDate = DateTime.MinValue;
                foreach (var selectedOrder in selectedOrders)
                {
                    if (minDate > selectedOrder?.OrderDate)
                        minDate = selectedOrder.OrderDate;

                    if (maxDate < selectedOrder?.OrderDate)
                        maxDate = selectedOrder.OrderDate;
                }

                using SaveFileDialog exportSaveFileDialog = new()
                {
                    Title = "Select Pdf file",
                    Filter = "PDF(*.pdf)|*.pdf",
                    FileName = $"Orders_{minDate.ToString("dd/MM/yyyy")}_{maxDate.ToString("dd/MM/yyyy")}"
                };

                if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                {
                    if (await SaveAsFile(selectedOrders, exportSaveFileDialog.FileName, includeAllServices: true))
                    {
                        XtraMessageBox.Show("File saved successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Error during the save of the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> SaveAsFile(IEnumerable<Order?> orders, string fileName, bool includeAllServices = false)
        {
            List<Service>? services = null;
            if (includeAllServices)
            {
                var categories = await Program.ApiSdk.GetCategories();
                services = new();
                foreach (var category in categories ?? new List<Category>())
                    if (category != null && category.Services != null && category.Services.Any())
                        services.AddRange(category.Services);
            }

            List<string> reports = new();
            foreach (var order in orders)
                reports.Add(PrintUtils.GenerateReportDataSource(order, services));

            return PrintUtils.GenerateReportsFile(reports.ToArray(), Program.OrderReportPath, fileName);
        }

        private void SetCheckboxEdit<T>(GridControl grid, string colName, T checkedValue, T uncheckedValue, EventHandler ev = null)
        {
            try
            {
                RepositoryItemCheckEdit rce = new RepositoryItemCheckEdit();

                DevExpress.XtraGrid.Columns.GridColumn col = ((GridView)grid.Views.First()).Columns[colName];

                ((System.ComponentModel.ISupportInitialize)(rce)).BeginInit();

                grid.RepositoryItems.AddRange(new RepositoryItem[] { rce });
                col.ColumnEdit = rce;

                rce.Name = "riChk" + col.FieldName;
                rce.ValueChecked = checkedValue;
                rce.ValueUnchecked = uncheckedValue;
                rce.ValueGrayed = DBNull.Value;

                if (ev != null)
                    rce.DoubleClick += ev;

                ((System.ComponentModel.ISupportInitialize)(rce)).EndInit();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    
    }
}