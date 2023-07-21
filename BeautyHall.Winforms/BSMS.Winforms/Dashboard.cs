using BeautyHall.Api.SDK.Responses;
using DevExpress.Utils.Extensions;
using BSMS.UserControls;
using BSMS.Winforms.Forms;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;

namespace BSMS
{
    public partial class Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly BeautyHall.Api.SDK.Responses.Login User;
        private List<Form> OpenedForms;
        public Dashboard(BeautyHall.Api.SDK.Responses.Login user)
        {
            InitializeComponent();
            User = user;
            OpenedForms = new();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            usernameInfoElement.Text = $"Hello, {User.Name} {User.Surname}";
            ShowForm(new WelcomeForm(User));
        }

        private void ShowForm(Form form)
        {
            var existingForm = OpenedForms.Where(x => form.GetType() == x.GetType()).FirstOrDefault();
            if (existingForm != null)
                form = existingForm;
            else
                OpenedForms.Add(form);

            if (DisplayControl.Controls.Count > 0)
            {
                var currentControl = DisplayControl.Controls[0];
                if (currentControl.GetType() != form.GetType())
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
            form.FormClosed += OnSubFormClosed;
            form.Show();
        }

        private void OnSubFormClosed(object? sender, FormClosedEventArgs e)
        {
            var openedForm = OpenedForms.Where(x => sender?.GetType() == x.GetType()).FirstOrDefault();
            if (openedForm != null)
                OpenedForms.Remove(openedForm);
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            if (DisplayControl.Controls.Count > 0)
                DisplayControl.Controls[0].Size = DisplayControl.Size;
        }

        private void accordionControl1_StateChanged(object sender, EventArgs e)
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
            ShowForm(new OrderForm());
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            ShowForm(new InsertEmployee());
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

        private void productAccordionItem_Click(object sender, EventArgs e)
        {
            ShowForm(new WelcomeForm(User));
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            ShowForm(new InsertClient());
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            ShowForm(new AllOrdersForm());
        }
    }
}
