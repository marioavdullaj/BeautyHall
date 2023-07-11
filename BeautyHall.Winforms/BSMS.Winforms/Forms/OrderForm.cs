using BeautyHall.Api.SDK.Responses;
using Demo;
using DevExpress.XtraBars;
using DevExpress.Utils.Extensions;
using Demo.UserControls;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;

namespace BSMS.Winforms.Forms
{
    public partial class OrderForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IEnumerable<Category>? categories;
        private OrderDto CurrentOrder;
        private List<OrderService> ServiceToAdd = new();
        public OrderForm()
        {
            InitializeComponent();
        }

        private async void OrderForm_Load(object sender, EventArgs e)
        {
            categories = await Program.ApiSdk.GetCategories();
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

                CurrentOrder = new()
                {
                    OrderId = order.OrderId,
                    OrderDate = order.OrderDate
                };
                UpdateControls();

                // Add all services addable into the order
                if (categories == null) return;
                foreach (var category in categories)
                {
                    var categoryControl = new CategoryControl(category);
                    categoryControl.ServiceAdded += ServiceAdded_Handler;
                    ServicesFlowLayout.AddControl(categoryControl);
                }
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
                    OrderId = CurrentOrder.OrderId,
                    Service = args.Service,
                    Employee = args.Employee,
                    ServicePrice = args.Price ?? 0
                };

                ServiceToAdd.Add(added);
                var addedServiceControl = new AddedServiceControl(added);
                addedServiceControl.ServiceRemoved += ServiceRemoved_Handler;
                AddedServicesFlowLayout.AddControl(addedServiceControl);

                servicesInOrderLabel.Text = $"Services in Order. Total: {ServiceToAdd.Sum(x => x.ServicePrice)} €";
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
                var toRemove = AddedServicesFlowLayout.Controls.Cast<AddedServiceControl>().Where(x => x.OrderService == e.OrderService).FirstOrDefault();
                if (toRemove != null)
                {
                    AddedServicesFlowLayout.Controls.Remove(toRemove);
                    ServiceToAdd.Remove(e.OrderService);
                }

                servicesInOrderLabel.Text = $"Services in Order. Total: {ServiceToAdd.Sum(x => x.ServicePrice)} €";
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
                        XtraMessageBox.Show("Error during the cancellation of the Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}