using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMS
{
    public partial class Login : XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            var loginRequest = new LoginDto
            {
                Username = textEdit1.Text,
                Password = textEdit2.Text
            };

            var loginResponse = await Program.ApiSdk.GetLogin(loginRequest);
            if (loginResponse != null)
            {
                textEdit1.Text = ""; textEdit2.Text = "";
                this.Hide();
                Program.dashboard = new Dashboard(loginResponse);
                Program.dashboard.Show();
            }
            else
            {
                XtraMessageBox.Show("Login failed. Please try again.");
            }
        }

        private void Login_Shown(object sender, EventArgs e) { }
    }
}