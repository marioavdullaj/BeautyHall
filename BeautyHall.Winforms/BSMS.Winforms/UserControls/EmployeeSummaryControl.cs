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

namespace BSMS.Winforms.UserControls
{
    public partial class EmployeeSummaryControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeSummaryControl(List<string> serviceDescriptions, List<decimal> servicePrices)
        {
            InitializeComponent();
            AddServiceData(serviceDescriptions, servicePrices);
        }
        public void AddServiceData(List<string> serviceDescriptions, List<decimal> totalPrices)
        {
            // Adjust the index based on the number of labels you have
            for (int i = 0; i < serviceDescriptions.Count; i++)
            {
                // Assuming you have labels named lblControl1, lblControl2, lblControl3, ...
                Label lblControl = this.Controls.Find($"lblControl{i + 1}", true).FirstOrDefault() as Label;

                if (lblControl != null)
                {
                    lblControl.Text = $"Service Description: {serviceDescriptions[i]}\nTotal Price: {totalPrices[i].ToString("F2")}";
                }
            }
        }
    }
}
