using BeautyHall.Api.SDK.Requests;
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
using BSMS.Winforms.GenericUtils;

namespace BSMS.UserControls
{
    public partial class CategoryControl : DevExpress.XtraEditors.XtraUserControl
    {
        private Category Category { get; set; }
        public event EventHandler<ServiceAddedArgs> ServiceAdded;
        public CategoryControl(Category category)
        {
            InitializeComponent();
            this.Category = category;
        }

        private void ServiceControl_Load(object sender, EventArgs e)
        {
            labelServiceName.Text = $"{Category.CategoryName}";
            lookUpEdit2.Properties.DataSource = Category.Services;
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            var selectedService = Category.Services.Where(x => x.ServiceId == Functions.NullToInt(lookUpEdit2.EditValue)).FirstOrDefault();
            if (selectedService == null) return;

            lookUpEdit1.Properties.DataSource = selectedService?.Employees;

            List<decimal?> priceRange = new();
            for (decimal? i = selectedService?.ServiceMinimumPrice; i <= selectedService?.ServiceMaximumPrice; i++)
                priceRange.Add(i);
            lookUpEdit3.Properties.DataSource = priceRange;
            lookUpEdit3.EditValue = priceRange.FirstOrDefault();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (lookUpEdit2.EditValue is null)
            {
                XtraMessageBox.Show("Select a service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lookUpEdit1.EditValue is null)
            {
                XtraMessageBox.Show("Select an employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedService = Category.Services.Where(x => x.ServiceId == Functions.NullToInt(lookUpEdit2.EditValue)).First();
            var selectedEmployee = selectedService.Employees.Where(x => x.EmployeeId == Functions.NullToInt(lookUpEdit1.EditValue)).First();
            ServiceAdded?.Invoke(this, new ServiceAddedArgs
            {
                Service = selectedService
                ,
                Employee = selectedEmployee
                ,
                Price = Functions.NullToDecimal(lookUpEdit3.EditValue)
            });

            lookUpEdit1.EditValue = null;
            lookUpEdit2.EditValue = null;
            lookUpEdit3.EditValue = null;
        }
    }
    public class ServiceAddedArgs : EventArgs
    {
        public Service? Service { get; set; }
        public Employee? Employee { get; set; }
        public decimal? Price { get; set; }
    }
}
