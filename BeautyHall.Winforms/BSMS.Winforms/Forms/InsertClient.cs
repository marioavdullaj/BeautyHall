using BSMS.Winforms.GenericUtils;
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
using BeautyHall.Api.SDK.Responses;
using Demo;
using BSMS.Winforms.Models;
using DevExpress.Utils.Extensions;
using Demo.UserControls;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;
using BeautyHall.Api.SDK;

namespace BSMS.Winforms.Forms
{
    public partial class InsertClient : FixedRibbonForm
    {
        private Customer customer;
        private IEnumerable<Customer>? Customers;

        public InsertClient()
        {
            InitializeComponent();
            
        }

        private void SaveClientButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var customer = new Customer();
          {
            customer.Id = 0;
            customer.Surname = lookUpEdit1.Text;
            customer.Name = textBox1.Text;
            customer.Tel = textBox2.Text;
            customer.Email = textBox3.Text;
          };
         
            
          
        }
    }
}