using BeautyHall.Api.SDK.Responses;
using DevExpress.Utils.Extensions;
using Demo.UserControls;
using BSMS.Winforms.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;

namespace Demo
{
    public partial class Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly BeautyHall.Api.SDK.Responses.Login User;
        public Dashboard(BeautyHall.Api.SDK.Responses.Login user)
        {
            InitializeComponent();
            User = user;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            usernameInfoElement.Text = $"Hello, {User.Name} {User.Surname}";
            ShowForm<WelcomeForm>(new WelcomeForm(User));
        }

        private void ShowForm<TForm>(Form form)
        {
            if (DisplayControl.Controls.Count > 0)
            {
                var currentControl = DisplayControl.Controls[0];
                if (currentControl is not TForm)
                {
                    DisplayControl.Controls.Remove(currentControl);
                }
                else
                    return;
            }
            form.TopMost = true;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = DisplayControl.Size;
            DisplayControl.Controls.Add(form);
            form.Show();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if (DisplayControl.Controls.Count > 0)
                DisplayControl.Controls[0].Size = DisplayControl.Size;
        }

        private void OnFormClosed(object? sender, FormClosedEventArgs e)
        {
            Program.login.Show();
        }

        private void newOrderAccordionItem_Click(object sender, EventArgs e)
        {
            ShowForm<OrderForm>(new OrderForm());
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //categories?.ForEach(category => NewOrderServicesFlowLayout.AddControl(new CategoryControl(category)));
        }

        private void usernameInfoElement_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
