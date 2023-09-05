using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Utils;
using DevExpress.XtraEditors.Repository;
using System.Linq;
using DevExpress.XtraCharts.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BSMS.Winforms.Forms
{
    public partial class ClientHistory : FixedRibbonForm
    {
        DataSet ds;
        private IEnumerable<Order>? orders;
        private IEnumerable<Subject>? subjects;
        public ClientHistory()
        {
            InitializeComponent();
            ds = new();
        }

        private async void ClientHistory_Load(object sender, EventArgs e)
        {
            baritemDateFrom.EditValue = new DateTime(2023, 4, 4);
            barItemDateTo.EditValue = DateTime.Today;
            try
            {
                subjects = await Program.ApiSdk.GetSubjects();
                //var clients = await Program.ApiSdk.GetSubjects();

                if (subjects != null)
                {
                    var clients = subjects.Where(x => x.SubjectType == 0).Select(x => new Customer
                    {
                        Id = x.SubjectId,
                        Surname = x.SubjectLastName,
                        Name = x.SubjectName
                    });
                    lookUpEdit1.Properties.DataSource = clients;
                    lookUpEdit1.Properties.DisplayMember = "Surname"; // Adjust property name as needed
                    lookUpEdit1.Properties.ValueMember = "Id"; // Adjust property name as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            await Reload();
        }
        private void grvOrders_MasterRowExpanding(object sender, MasterRowCanExpandEventArgs e)
        {
            try
            {
                DataRow dr = grvOrders.GetDataRow(e.RowHandle);
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

                    grvProducts.ViewCaption = "Products in order";
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

        private async Task Reload()
        {
            try
            {
                ClearData();
                DataRelation dRel;
                orders = await Program.ApiSdk.GetOrders((DateTime)baritemDateFrom.EditValue, (DateTime)barItemDateTo.EditValue);
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
                grOrders.DataSource = dt1;
                grOrders.Refresh();
            }
            catch (Exception)
            {
                // Handle exceptions
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
        private void ClearData()
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        private async void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lookUpEdit1.EditValue != null)
                {
                    int selectedClientId = (int)lookUpEdit1.EditValue;

                    // Get the selected client's orders within the specified date range
                    DateTime fromDate = (DateTime)baritemDateFrom.EditValue;
                    DateTime toDate = (DateTime)barItemDateTo.EditValue;

                    // Call the GetOrders method and await its result
                    IEnumerable<Order>? clientOrders = await GetOrdersForClient(selectedClientId, fromDate, toDate);

                    if (clientOrders != null)
                    {
                        // Assuming grOrders is the name of your GridView control
                        grOrders.DataSource = clientOrders;

                        var selectedCustomer = subjects?.FirstOrDefault(x => x.SubjectId == selectedClientId);
                        if (selectedCustomer != null)
                        {
                            Text = $"{selectedCustomer.SubjectName} {selectedCustomer.SubjectLastName} |";
                            baritemId.EditValue = selectedCustomer.SubjectId.ToString();
                            barItemName.EditValue = selectedCustomer.SubjectName;
                            barItemSurname.EditValue = selectedCustomer.SubjectLastName;
                            baritemEmail.EditValue = selectedCustomer.Email;
                            baritemPhone.EditValue = selectedCustomer.PhoneNumber;
                            baritemRegisterDate.EditValue = selectedCustomer.RegistrationDate.ToString();
                        }
                    }
                    else
                    {
                        // Handle the case where clientOrders is null
                        MessageBox.Show("No orders found for the selected client.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private async void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            await Reload();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearData();
        }
    }
}