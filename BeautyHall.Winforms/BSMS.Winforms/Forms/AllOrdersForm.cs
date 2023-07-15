using BeautyHall.Api.SDK.Responses;
using Demo;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMS.Winforms.Forms
{
    public partial class AllOrdersForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IEnumerable<Order>? orders;
        public AllOrdersForm()
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
            grOrders.DataSource = orders;
        }

        private void grOrders_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = DateTime.Today;
            dateTo.EditValue = DateTime.Today.AddDays(1);
        }
    }
}