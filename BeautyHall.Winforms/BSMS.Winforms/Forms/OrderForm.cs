using BeautyHall.Api.SDK.Responses;
using Demo;
using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using Demo.UserControls;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;
using System.Data;
using BSMS.Winforms.Models;
using BSMS.Winforms.GenericUtils;

namespace BSMS.Winforms.Forms
{
    public partial class OrderForm : FixedRibbonForm
    {
        private IEnumerable<Category>? categories;
        private IEnumerable<Subject>? subjects;
        private Order? CurrentOrder;
        public OrderForm()
        {
            InitializeComponent();
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateNewOrder();
        }

        private async void CreateNewOrder()
        {
            try
            {
                var order = await Program.ApiSdk.UpsertOrder(new OrderDto());
                if (order == null)
                {
                    XtraMessageBox.Show("Error during the creation of a new Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                CurrentOrder = order;
                CurrentOrder.OrderServices = new List<OrderService>();
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

                servicesInOrderLabel.Text = $"Services in Order. Total: {CurrentOrder.OrderServices.Sum(x => x.ServicePrice)} €";
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

                servicesInOrderLabel.Text = $"Services in Order. Total: {CurrentOrder?.OrderServices?.Sum(x => x.ServicePrice)} €";
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
                textEdit1.Text = $"ORDER_{CurrentOrder.OrderId}";
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
                        XtraMessageBox.Show("The order cannot be deleted anymore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        paymentButton.Enabled = false;
                        paymentButton.ButtonStyle = BarButtonStyle.Check;
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
                    XtraMessageBox.Show("Select customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    CurrentOrder = await Program.ApiSdk.GetOrder(CurrentOrder?.OrderId ?? 0);
                    if (alertSaved)
                        XtraMessageBox.Show("Order saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}