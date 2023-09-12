using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Utils;
using System.Linq;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BSMS.Winforms.Forms
{
    public partial class CustomerSummaryForm : FixedRibbonForm
    {
        DataSet ds;
        private IEnumerable<Order>? orders;
        private IEnumerable<Subject> subjects;
        private IEnumerable<Order> allOrders; // Store all orders
        private IEnumerable<Order> filteredOrders;

        public CustomerSummaryForm()
        {
            InitializeComponent();
            ds = new();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private async Task Reload()
        {
            try
            {

                DataRelation dRel;
                orders = await Program.ApiSdk.GetOrders((DateTime)dateFrom.EditValue, (DateTime)dateTo.EditValue);
                var orderSummary = orders?.Select(x => new OrderSummary
                {
                    Id = x.OrderId,
                    Date = x.OrderDate,
                    CustomerFullName = x.Customer != null ? $"{x.Customer.SubjectLastName} {x.Customer.SubjectName}" : "",
                    Notes = x.Notes,
                    TotalPrice = x.OrderServices?.Sum(x => x.ServicePrice) + x.OrderProducts?.Sum(x => x.TotalPrice),
                    DiscountedPrice = x.PaymentSummaries.FirstOrDefault()?.DiscountedPrice ?? 0,
                    TotalPOS = x.PaymentSummaries.FirstOrDefault()?.TotalPOS ?? 0,
                    TotalCash = x.PaymentSummaries.FirstOrDefault()?.TotalCash ?? 0,
                    Payed = x.PaymentSummaries != null && x.PaymentSummaries.Any(),
                    ProductsInOrder = x.OrderProducts,
                    ExistProductsInOrder = x.OrderProducts != null && x.OrderProducts.Any(),
                    DiscountPercentage = (x.PaymentSummaries == null || !x.PaymentSummaries.Any()) ? "" : $"{(1 - (x.OrderServices?.Sum(x => x.ServicePrice) + x.OrderProducts?.Sum(x => x.TotalPrice) > 0 ? ((x.PaymentSummaries?.FirstOrDefault()?.DiscountedPrice ?? 0) / (x.OrderServices?.Sum(x => x.ServicePrice) + x.OrderProducts?.Sum(x => x.TotalPrice))) : 1)):P}"
                });

                var dt1 = OrderSummaryToDataTable(orderSummary);
                dt1.TableName = "OrderSummary";
                ds.Tables.Add(dt1);

                var dt2 = OrderProductToDataTable(null);
                dt2.TableName = "OrderProducts";
                ds.Tables.Add(dt2);

                if (dt1.Rows.Count > 0)
                {
                    dRel = new("Products in order", dt1.Columns["Id"], dt2.Columns["OrderId"]);
                    ds.Relations.Add(dRel);
                }
                gcClientOrders.DataSource = dt1;
                gcClientOrders.Refresh();
            }
            catch (Exception)
            {

            }
        }
        private DataTable OrderSummaryToDataTable(IEnumerable<OrderSummary>? orders)
        {
            DataTable dtO = new();
            dtO.Columns.Add("Id");
            dtO.Columns.Add("CustomerFullName");
            dtO.Columns.Add("Date");
            dtO.Columns.Add("Notes");
            dtO.Columns.Add("ExistProductsInOrder", typeof(bool));
            dtO.Columns.Add("TotalPrice");
            dtO.Columns.Add("Payed", typeof(bool));
            dtO.Columns.Add("DiscountedPrice");
            dtO.Columns.Add("DiscountPercentage");
            dtO.Columns.Add("TotalCash");
            dtO.Columns.Add("TotalPOS");

            try
            {
                if (orders != null && orders.Any())
                {
                    foreach (var o in orders)
                    {
                        dtO.Rows.Add(
                            o.Id,
                            o.CustomerFullName,
                            o.Date,
                            o.Notes,
                            o.ExistProductsInOrder,
                            o.TotalPrice,
                            o.Payed,
                            o.DiscountedPrice,
                            o.DiscountPercentage,
                            o.TotalCash,
                            o.TotalPOS);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            return dtO;
        }

        private DataTable OrderProductToDataTable(IEnumerable<OrderProduct>? products)
        {
            DataTable dtP = new();
            dtP.Columns.Add("OrderId");
            dtP.Columns.Add("ProductCode");
            dtP.Columns.Add("ProductDescription");
            dtP.Columns.Add("ProductQuantity");
            dtP.Columns.Add("TotalPrice");
            try
            {
                if (products != null && products.Any())
                {
                    foreach (var p in products)
                    {
                        dtP.Rows.Add(
                            p.OrderId,
                            p.Product?.ProductCode,
                            p.Product?.ProductDescription,
                            p.ProductQuantity,
                            p.TotalPrice);
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            return dtP;
        }
        public void ClearData()
        {
            try
            {
                ds.Relations.Clear();

                foreach (DataTable dt in ds.Tables)
                {
                    dt.Constraints.Clear();
                }

                ds.Tables.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void lueCustomer_EditValueChanged(object sender, EventArgs e)
        {
            await Reload();
            try
            {
                if (lueCustomer.EditValue != null)
                {
                    int selectedClientId = (int)lueCustomer.EditValue;
                    DateTime fromDate = (DateTime)dateFrom.EditValue;
                    DateTime toDate = (DateTime)dateTo.EditValue;

                    // Assuming GetOrdersForClient fetches orders for the selected client
                    IEnumerable<Order>? clientOrders = await GetOrdersForClient(selectedClientId, fromDate, toDate);

                    // Convert clientOrders to OrderSummary and then to DataTable
                    var clientOrdersDataTable = OrderSummaryToDataTable(clientOrders.Select(x => new OrderSummary
                    {
                        Id = x.OrderId,
                        Date = x.OrderDate,
                        CustomerFullName = x.Customer != null ? $"{x.Customer.SubjectLastName} {x.Customer.SubjectName}" : "",
                        //Notes = x.Notes,
                        TotalPrice = x.OrderServices?.Sum(y => y.ServicePrice) + x.OrderProducts?.Sum(y => y.TotalPrice),
                        DiscountedPrice = x.PaymentSummaries.FirstOrDefault()?.DiscountedPrice ?? 0,
                        TotalPOS = x.PaymentSummaries.FirstOrDefault()?.TotalPOS ?? 0,
                        TotalCash = x.PaymentSummaries.FirstOrDefault()?.TotalCash ?? 0,
                        Payed = x.PaymentSummaries != null && x.PaymentSummaries.Any(),
                        ProductsInOrder = x.OrderProducts,
                        ExistProductsInOrder = x.OrderProducts != null && x.OrderProducts.Any(),
                        DiscountPercentage = (x.PaymentSummaries == null || !x.PaymentSummaries.Any()) ? "" : $"{(1 - (x.OrderServices?.Sum(y => y.ServicePrice) + x.OrderProducts?.Sum(y => y.TotalPrice) > 0 ? ((x.PaymentSummaries?.FirstOrDefault()?.DiscountedPrice ?? 0) / (x.OrderServices?.Sum(y => y.ServicePrice) + x.OrderProducts?.Sum(y => y.TotalPrice))) : 1)):P}"
                    }));
                    CalculateAndDisplaySummary(clientOrders);
                    // Update the grid to display orders for the selected client
                    gcClientOrders.DataSource = clientOrdersDataTable;
                    //grOrders.Refresh();

                    // Update bar items if needed, based on the selected client
                    var selectedCustomer = subjects?.FirstOrDefault(x => x.SubjectId == selectedClientId);
                    if (selectedCustomer != null)
                    {
                        txteClientId.EditValue = selectedCustomer.SubjectId;
                        txteSurname.EditValue = selectedCustomer.SubjectLastName;
                        txteName.EditValue = selectedCustomer.SubjectName;
                        txtePhone.EditValue = selectedCustomer.PhoneNumber;
                        txteEmail.EditValue = selectedCustomer.Email;
                        txteRegDate.EditValue = selectedCustomer.RegistrationDate ?? DateTime.MinValue;
                        textEdit1.EditValue = $"{clientOrders.Count()} Orders";

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void gcClientOrders_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = new DateTime(2023, 4, 4);
            dateTo.EditValue = DateTime.Today;
            try
            {
                allOrders = await Program.ApiSdk.GetOrders();
                subjects = await Program.ApiSdk.GetSubjects();

                if (subjects != null)
                {
                    var clients = subjects.Where(x => x.SubjectType == 0).Select(x => new Customer
                    {
                        Id = x.SubjectId,
                        Surname = x.SubjectLastName,
                        Name = x.SubjectName
                    });
                    lueCustomer.Properties.DataSource = clients;
                    lueCustomer.Properties.DisplayMember = "Surname";
                    lueCustomer.Properties.ValueMember = "Id";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvClientsOrders_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            try
            {
                DataRow dr = gvClientsOrders.GetDataRow(e.RowHandle);
                DataTable dtTmp;
                int idOrder;

                if (dr != null)
                {
                    idOrder = Convert.ToInt32(dr["Id"]);
                    DataTable dtProduct = new();
                    dtProduct.Columns.Add("VAL", typeof(Int32));
                    DataRow row = dtProduct.NewRow();
                    row["VAL"] = idOrder;
                    dtProduct.Rows.Add(row);

                    gvClientProduct.ViewCaption = "Products in order";
                    dtTmp = OrderProductToDataTable(orders?.Where(x => x.OrderId == idOrder).First()?.OrderProducts);

                    ds.Tables["OrderProducts"].Clear();
                    ds.Tables["OrderProducts"].Merge(dtTmp);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<IEnumerable<Order>?> GetOrdersForClient(int clientId, DateTime from, DateTime to)
        {
            try
            {
                // Retrieve all orders
                var allOrders = await Program.ApiSdk.GetOrders();

                // Filter orders for the selected client within the date range
                var clientOrders = allOrders
                    .Where(o => o.CustomerId == clientId && o.OrderDate >= from && o.OrderDate <= to)
                    .ToList();

                return clientOrders;
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                XtraMessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void CalculateAndDisplaySummary(IEnumerable<Order> clientOrders)
        {
            // Calculate Total POS
            decimal totalPOS = clientOrders.Sum(x => x.PaymentSummaries.FirstOrDefault()?.TotalPOS ?? 0);

            // Calculate Total Cash
            decimal totalCash = clientOrders.Sum(x => x.PaymentSummaries.FirstOrDefault()?.TotalCash ?? 0);

            // Calculate Total Summary
            decimal totalSummary = totalPOS + totalCash;

            // Calculate Total Products
            decimal totalPriceForProducts = clientOrders.Sum(x => x.OrderProducts?.Sum(p => p.TotalPrice) ?? 0);

            // Display the calculated values in the text labels
            txtTotalPOS.EditValue = $"{totalPOS} €";
            txtTotalCash.EditValue = $"{totalCash} €";
            txtTotalSummary.EditValue = $"{totalSummary} €";
            txtTotalProducts.EditValue = $"{totalPriceForProducts} €";
        }

    }
}


