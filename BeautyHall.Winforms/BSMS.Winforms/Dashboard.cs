using BSMS.Winforms.Forms;

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

        public void ShowForm(Form form)
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
            if (OpenedForms.Count() > 0)
            {
                var reopen = OpenedForms.Last();
                ShowForm(reopen);
            }
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
            Program.login.Close();
        }

        private void newOrderAccordionItem_Click(object sender, EventArgs e)
        {
            ShowForm(new OrderForm());
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeForm());
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void usernameInfoElement_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void productAccordionItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProductForm());
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            ShowForm(new CustomerForm());
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            ShowForm(new OrderHistoryForm());
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            ShowForm(new DailySummaryForm());
        }

        private void StockAccordionItem_Click(object sender, EventArgs e)
        {
            ShowForm(new StockProductForm());
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            ShowForm(new TotalSummaryForm());
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            ShowForm(new ClientHistoryForm());
        }
    }
}
