using BeautyHall.Api.SDK.Responses;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMS.Winforms.UserControls
{
    public partial class OrderProductControl : DevExpress.XtraEditors.XtraUserControl
    {
        public OrderProduct OrderProduct { get; set; }
        public event EventHandler<RemovesOrderProductArgs> ProductRemoved;
        public OrderProductControl(OrderProduct orderProduct, bool deletable = false)
        {
            InitializeComponent();
            OrderProduct = orderProduct;
            labelControl2.Text = $"{orderProduct.Product?.ProductCode} {orderProduct.Product?.ProductDescription}";
            labelControl3.Text = orderProduct.ProductQuantity.ToString();
            labelControl5.Text = orderProduct.TotalPrice.ToString("C2");
            simpleButton1.Visible = deletable;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProductRemoved?.Invoke(this, new RemovesOrderProductArgs { OrderProduct = OrderProduct });
        }
    }

    public class RemovesOrderProductArgs : EventArgs
    {
        public OrderProduct? OrderProduct { get; set; }
    }
}
