using BeautyHall.Api.SDK.Responses;
namespace BSMS.Winforms.UserControls
{
    public partial class OrderServiceControl : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderService OrderService { get; set; }
        public event EventHandler<RemoveOrderServiceArgs> ServiceRemoved;
        public OrderServiceControl(OrderService orderService, bool deletable = false)
        {
            InitializeComponent();
            OrderService = orderService;
            labelControl2.Text = orderService.Service?.ServiceDescription;
            labelControl3.Text = $" {orderService.Employee?.EmployeeCode}    {orderService.Employee?.EmployeeName}";
            labelControl5.Text = $"{orderService.ServicePrice} €";
            simpleButton1.Visible = deletable;
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
