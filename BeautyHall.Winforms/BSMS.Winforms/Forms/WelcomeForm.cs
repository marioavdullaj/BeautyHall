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

namespace BSMS.Winforms.Forms
{
    public partial class WelcomeForm : DevExpress.XtraEditors.XtraForm
    {
        public WelcomeForm(BeautyHall.Api.SDK.Responses.Login user)
        {
            InitializeComponent();
            labelControl1.Text = $"Welcome back, {user.Name} {user.Surname}";
        }
    }
}