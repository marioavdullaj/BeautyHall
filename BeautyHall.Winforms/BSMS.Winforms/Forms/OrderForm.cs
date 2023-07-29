using BeautyHall.Api.SDK.Responses;
using BSMS;
using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using BSMS.UserControls;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;
using System.Data;
using BSMS.Winforms.Models;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Utils;

namespace BSMS.Winforms.Forms
{
    public partial class OrderForm : FixedRibbonForm
    {
        private IEnumerable<Category>? categories;
        private IEnumerable<Subject>? subjects;
        private IEnumerable<Product>? products;
        private Order? CurrentOrder;
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order? order)
        {
            InitializeComponent();
            CurrentOrder = order;
        }

        private void EnableOrderButtons(bool enable)
        {
            OrderHeaderPanel.Enabled = enable;
            saveOrderButton.Enabled = enable;
            cancelOrderButton.Enabled = enable;
            printButton.Enabled = enable;
            paymentButton.Enabled = enable;
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            EnableOrderButtons(false);
            try
            {
                categories = await Program.ApiSdk.GetCategories();
                subjects = await Program.ApiSdk.GetSubjects();
                products = await Program.ApiSdk.GetAllProducts();

                if (subjects != null)
                {
                    var clients = subjects.Where(x => x.SubjectType == 0).Select(x => new Customer
                    {
                        Id = x.SubjectId,
                        Surname = x.SubjectLastName,
                        Name = x.SubjectName
                    });

                    lookUpEdit1.Properties.DisplayMember = "Surname";
                    lookUpEdit1.Properties.ValueMember = "Id";
                    lookUpEdit1.Properties.DataSource = clients;
                }

                if (CurrentOrder != null)
                {
                    saveOrderButton.Enabled = true;
                    cancelOrderButton.Enabled = true;
                    printButton.Enabled = true;
                    paymentButton.Enabled = true;

                    if (CurrentOrder.PaymentSummaries.Any())
                    {
                        paymentButton.Visibility = BarItemVisibility.Never;
                        barButtonItem1.Visibility = BarItemVisibility.Always;
                    }
                    //panelControl4.Visible = false;
                    //panelControl5.Dock = DockStyle.Fill;
                    foreach (var category in categories)
                    {
                        var categoryControl = new CategoryControl(category);
                        categoryControl.ServiceAdded += ServiceAdded_Handler;
                        ServicesFlowPanel.AddControl(categoryControl);
                    }
                    EnableOrderButtons(true);

                    addOrderButton.Visibility = BarItemVisibility.Never;
                    textEdit1.Text = CurrentOrder?.OrderId.ToString();
                    dateEdit1.DateTime = CurrentOrder?.OrderDate ?? DateTime.Now;
                    lookUpEdit1.EditValue = CurrentOrder?.Customer?.SubjectId;
                    textEdit2.EditValue = CurrentOrder?.Customer?.SubjectName;
                    textEdit3.EditValue = CurrentOrder?.Customer?.PhoneNumber;
                    textEdit4.EditValue = CurrentOrder?.Customer?.Email;
                    memoEdit1.EditValue = CurrentOrder?.Notes;

                    foreach (var service in CurrentOrder.OrderServices)
                    {
                        var addedServiceControl = new OrderServiceControl(service, deletable: true);
                        addedServiceControl.ServiceRemoved += ServiceRemoved_Handler;
                        AddedServicesFlowLayout.AddControl(addedServiceControl);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            var selectedCustomer = subjects?.Where(x => x.SubjectId == Convert.ToInt32(lookUpEdit1.EditValue)).FirstOrDefault();
            Text = $"{selectedCustomer?.SubjectName} {selectedCustomer?.SubjectLastName} "
                + (selectedCustomer != null ? "|" : "")
                + $" {dateEdit1.DateTime:dd/MM/yyyy}";

            textEdit2.Text = $"{selectedCustomer?.SubjectName}";
            textEdit3.Text = $"{selectedCustomer?.PhoneNumber}";
            textEdit4.Text = $"{selectedCustomer?.Email}";
        }

        private void addOrderButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewOrder();
        }

        private void ResetUI()
        {
            AddedServicesFlowLayout.Controls.Clear();
            ServicesFlowPanel.Controls.Clear();
            servicesInOrderLabel.Text = "Κάρτα Υπηρεσίας :";
            textEdit1.EditValue = null;
            textEdit2.EditValue = null;
            textEdit3.EditValue = null;
            textEdit4.EditValue = null;
            dateEdit1.DateTime = DateTime.Today;
            lookUpEdit1.EditValue = null;
        }

        private void CreateNewOrder()
        {
            try
            {
                var order = new Order
                {
                    OrderDate = DateTime.Now
                };

                if (order == null)
                {
                    XtraMessageBox.Show("Error during the creation of a new Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                CurrentOrder = order;
                CurrentOrder.OrderServices = new List<OrderService>();
                ResetUI();
                UpdateControls();

                // Add all services addable into the order
                if (categories == null) return;
                foreach (var category in categories)
                {
                    var categoryControl = new CategoryControl(category);
                    categoryControl.ServiceAdded += ServiceAdded_Handler;
                    ServicesFlowPanel.AddControl(categoryControl);
                }
                EnableOrderButtons(true);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServiceAdded_Handler(object? sender, ServiceAddedArgs args)
        {
            try
            {
                var added = new OrderService
                {
                    OrderId = CurrentOrder?.OrderId ?? 0,
                    Service = args.Service,
                    ServiceId = args.Service?.ServiceId ?? 0,
                    Employee = args.Employee,
                    EmployeeId = args.Employee?.EmployeeId ?? 0,
                    ServicePrice = args.Price ?? 0
                };

                ((List<OrderService>)CurrentOrder.OrderServices).Add(added);
                var addedServiceControl = new OrderServiceControl(added, deletable: true);
                addedServiceControl.ServiceRemoved += ServiceRemoved_Handler;
                AddedServicesFlowLayout.AddControl(addedServiceControl);

                servicesInOrderLabel.Text = $"Κάρτα Υπηρεσιών. Σύνολο: {CurrentOrder.OrderServices.Sum(x => x.ServicePrice)} €";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServiceRemoved_Handler(object? sender, RemoveOrderServiceArgs e)
        {
            try
            {
                if (e == null || e.OrderService == null) return;
                var toRemove = AddedServicesFlowLayout.Controls.Cast<OrderServiceControl>().Where(x => x.OrderService == e.OrderService).FirstOrDefault();
                if (toRemove != null)
                {
                    AddedServicesFlowLayout.Controls.Remove(toRemove);
                    var orderServices = CurrentOrder?.OrderServices.ToList();
                    var serviceToRemove = orderServices?.Where(x => x.ServiceId == e.OrderService.ServiceId).FirstOrDefault();
                    if (serviceToRemove != null)
                        orderServices?.Remove(serviceToRemove);

                    if (CurrentOrder != null)
                        CurrentOrder.OrderServices = orderServices;
                }

                servicesInOrderLabel.Text = $"Κάρτα Υπηρεσιών. Σύνολο: {CurrentOrder?.OrderServices?.Sum(x => x.ServicePrice)} €";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateControls()
        {
            if (CurrentOrder != null)
            {
                textEdit1.Text = CurrentOrder.OrderId > 0 ? $"ORDER_{CurrentOrder.OrderId}" : "";
                dateEdit1.EditValue = CurrentOrder.OrderDate;
                memoEdit1.EditValue = CurrentOrder.Notes;
            }
        }

        private async void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (CurrentOrder != null)
                {
                    if (await Program.ApiSdk.DeleteOrder(CurrentOrder.OrderId))
                        this.Close();
                    else
                        XtraMessageBox.Show("Η υπηρεσία δεν μπορεί να διαγραφή πλέον.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (await SaveOrder(alertSaved: false))
                {
                    PaymentSummaryForm paymentSummaryForm = new(CurrentOrder);
                    if (paymentSummaryForm.ShowDialog() == DialogResult.OK)
                    {
                        paymentButton.Visibility = BarItemVisibility.Never;
                        barButtonItem1.Visibility = BarItemVisibility.Always;

                        CurrentOrder = await Program.ApiSdk.GetOrder(CurrentOrder?.OrderId ?? 0);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> SaveOrder(bool alertSaved = true)
        {
            try
            {
                var selectedCustomer = subjects?.Where(x => x.SubjectId == GenericUtils.Functions.NullToInt(lookUpEdit1.EditValue)).FirstOrDefault();
                if (selectedCustomer == null)
                {
                    XtraMessageBox.Show("Επιλογή Πελάτη", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var updateOrder = new OrderDto
                {
                    OrderId = CurrentOrder?.OrderId ?? 0,
                    CustomerId = selectedCustomer.SubjectId,
                    Notes = memoEdit1.Text,
                    OrderDate = dateEdit1.DateTime,
                    Services = CurrentOrder?.OrderServices?.Select(x => new OrderServiceDto
                    {
                        EmployeeId = x.EmployeeId,
                        ServiceId = x.ServiceId,
                        ServicePrice = x.ServicePrice,
                        OrderId = CurrentOrder.OrderId
                    })
                };

                var savedOrder = await Program.ApiSdk.UpsertOrder(updateOrder);
                if (savedOrder == null)
                {
                    XtraMessageBox.Show("Error during the update of the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    CurrentOrder = await Program.ApiSdk.GetOrder(savedOrder.OrderId);
                    if (alertSaved)
                        XtraMessageBox.Show("Η Υπηρεσία Αποθηκεύτηκε!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateControls();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

        private async void saveOrderButton_ItemClick(object sender, ItemClickEventArgs e) => await SaveOrder();

        private async void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!(CurrentOrder?.PaymentSummaries.Any() ?? false))
                    return;

                var question = XtraMessageBox.Show("Do you wanna cancel the previous payment?", "Delete payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    int paymentId = CurrentOrder?.PaymentSummaries.First().PaymentId ?? 0;
                    var result = await Program.ApiSdk.DeletePayment(paymentId);
                    if (result)
                    {
                        XtraMessageBox.Show("The payment has been successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CurrentOrder = await Program.ApiSdk.GetOrder(CurrentOrder?.OrderId ?? 0);

                        barButtonItem1.Enabled = false;
                        paymentButton.Enabled = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Error during the save of the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            using SaveFileDialog exportSaveFileDialog = new()
            {
                Title = "Select Pdf file",
                Filter = "PDF(*.pdf)|*.pdf",
                FileName = $"ORDER{CurrentOrder?.OrderId}_{CurrentOrder?.Customer?.SubjectLastName} {CurrentOrder?.Customer?.SubjectName}_{CurrentOrder?.OrderDate.ToString("dd-MM-yyyy")}"
            };
            if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
            {
                if (SaveAsFile(exportSaveFileDialog.FileName, includeAllServices: true))
                {
                    XtraMessageBox.Show("File saved successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Error during the save of the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveAsFile(string fileName, bool includeAllServices = false)
        {
            List<Service>? services = null;
            if (includeAllServices)
            {
                services = new();
                foreach (var category in categories ?? new List<Category>())
                    if (category != null && category.Services != null && category.Services.Any())
                        services.AddRange(category.Services);
            }

            var report = PrintUtils.GenerateReportDataSource(CurrentOrder, services);
            return PrintUtils.GenerateReportFile(report, Program.OrderReportPath, fileName);
        }

        private void addProductButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addProductForm = new AddProductOrderForm(products);
            if(addProductForm.ShowDialog() == DialogResult.OK)
            {
                var selectedProduct = addProductForm.SelectedProduct;
                var selectedQuantity = addProductForm.SelectedQuantity;

                // do stuff here
            }
        }

        private async void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // while the form is closing, we save the order not to lose our work
            await SaveOrder(alertSaved: false);
        }
    }
}