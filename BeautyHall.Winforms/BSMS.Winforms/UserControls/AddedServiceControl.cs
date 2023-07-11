using BeautyHall.Api.SDK.Responses;
namespace BSMS.Winforms.UserControls
{
    public partial class AddedServiceControl : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderService OrderService { get; set; }
        public event EventHandler<RemoveOrderServiceArgs> ServiceRemoved;
        public AddedServiceControl(OrderService orderService)
        {
            InitializeComponent();
            OrderService = orderService;
            labelControl2.Text = orderService.Service?.ServiceDescription;
            labelControl3.Text = $"{orderService.Employee?.EmployeeName} {orderService.Employee?.EmployeeLastName}";
            labelControl5.Text = $"{orderService.ServicePrice} €";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ServiceRemoved?.Invoke(this, new RemoveOrderServiceArgs { OrderService = OrderService });
        }
    }

    public class RemoveOrderServiceArgs : EventArgs
    {
        public OrderService? OrderService { get; set; }
    }
}
