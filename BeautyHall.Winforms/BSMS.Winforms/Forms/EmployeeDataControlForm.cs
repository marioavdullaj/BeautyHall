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

namespace BSMS.Winforms.Forms
{
    public partial class EmployeeDataControlForm : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeDataControlForm(List<string> serviceDescriptions, List<decimal> servicePrices)
        {
            InitializeComponent();
            AddServiceData(serviceDescriptions, servicePrices);
        }
        // Method to add service data dynamically
        public void AddServiceData(List<string> serviceDescriptions, List<decimal> totalPrices)
        {
            // Implement the logic to add service data to your form controls here
            // For example, you can add labels or any other controls to display service data.
            for (int i = 0; i < serviceDescriptions.Count; i++)
            {
                // Create labels to display service descriptions and total prices
                Label labelDescription = new Label();
                labelDescription.Text = "Service Description: " + serviceDescriptions[i];
                labelDescription.Top = i * 30; // Adjust the position as needed
                this.Controls.Add(labelDescription);

                Label labelTotalPrice = new Label();
                labelTotalPrice.Text = "Total Price: " + totalPrices[i].ToString("F2");
                labelTotalPrice.Top = (i * 30) + 20; // Adjust the position as needed
                this.Controls.Add(labelTotalPrice);
            }
        }
    }
}