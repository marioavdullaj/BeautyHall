using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using BSMS;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using BSMS.Winforms.GenericUtils;

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
                    if(selectedOrder != null)
                    {
                        var orderForm = new OrderForm(selectedOrder);
                        Program.dashboard.ShowForm(orderForm);
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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