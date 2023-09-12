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



namespace BSMS.Winforms.Forms
{
    public partial class ClientHistoryForm : FixedRibbonForm
    {
        DataSet ds;
        private IEnumerable<Order>? orders;
        private IEnumerable<Subject> subjects;
        private IEnumerable<Order> allOrders; // Store all orders
        private IEnumerable<Order> filteredOrders;
        public ClientHistoryForm()
        {
            InitializeComponent();
            ds = new DataSet();

        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
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
                grOrders.DataSource = dt1;
                grOrders.Refresh();
            }
            catch (Exception)
            {

            }
        }
        private async void OrderForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            await Reload();
        }
       // private void grvOrders_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) { }
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
        private async void customerLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            await Reload();
            try
            {
                if (customerLookUpEdit.EditValue != null)
                {
                    int selectedClientId = (int)customerLookUpEdit.EditValue;
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

                    // Update the grid to display orders for the selected client
                    grOrders.DataSource = clientOrdersDataTable;
                    //grOrders.Refresh();

                    // Update bar items if needed, based on the selected client
                    var selectedCustomer = subjects?.FirstOrDefault(x => x.SubjectId == selectedClientId);
                    if (selectedCustomer != null)
                    {
                        baritemId.EditValue = selectedCustomer.SubjectId;
                        barItemSurname.EditValue = selectedCustomer.SubjectLastName;
                        barItemName.EditValue = selectedCustomer.SubjectName;
                        baritemPhone.EditValue = selectedCustomer.PhoneNumber;
                        baritemEmail.EditValue = selectedCustomer.Email;
                        baritemRegisterDate.EditValue = selectedCustomer.RegistrationDate ?? DateTime.MinValue;
                        textEdit1.EditValue = $"{clientOrders.Count()} Orders";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void grOrders_Load(object sender, EventArgs e)
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
                    customerLookUpEdit.Properties.DataSource = clients;
                    customerLookUpEdit.Properties.DisplayMember = "Surname";
                    customerLookUpEdit.Properties.ValueMember = "Id";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var selectedRows = grvOrders.GetSelectedRows();
                if (selectedRows != null && selectedRows.Length > 0)
                {
                    var firstSelectedRow = grvOrders.GetRow(selectedRows[0]) as DataRowView;
                    if (firstSelectedRow != null)
                    {
                        var selectedOrderId = Convert.ToInt32(firstSelectedRow["Id"]);
                        var selectedOrder = orders?.FirstOrDefault(o => o.OrderId == selectedOrderId);
                        if (selectedOrder != null)
                        {
                            var orderForm = new OrderForm(selectedOrder);
                            orderForm.FormClosed += OrderForm_FormClosed;
                            Program.dashboard.ShowForm(orderForm);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var selectedRows = grvOrders.GetSelectedRows();
                selectedRows = selectedRows.Select(x => grvOrders.GetDataSourceRowIndex(x)).ToArray();
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
                    if (await SaveAsFile(selectedOrders, exportSaveFileDialog.FileName, includeAllServices: false))
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

        private async void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private async void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

            {
                var CustomerSummaryForm = new CustomerSummaryForm();
                CustomerSummaryForm.FormClosed += OrderForm_FormClosed;
                Program.dashboard.ShowForm(CustomerSummaryForm);
            }
        }

        private void grvOrders_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e) { }
        
    }
}