using BSMS.Winforms.GenericUtils;
using DevExpress.XtraBars;
using System.Data;
using BeautyHall.Api.SDK.Responses;
using Demo;
using BSMS.Winforms.Models;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;

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
        private async void InsertClient_Load(object sender, EventArgs e)
        {
            EnableClientButtons(false);
            try
            {
                subjects = await Program.ApiSdk.GetSubjects();
                if (subjects != null)
                {
                    var clients = subjects.Where(x => x.SubjectType == 0).Select(x => new Customer
                    {
                        Id = x.SubjectId,
                        Surname = x.SubjectLastName,
                        Name = x.SubjectName
                    });

                    lookUpEdit1.Properties.DisplayMember = "Surname";
                    lookUpEdit1.Properties.ValueMember = "Id";
                    lookUpEdit1.Properties.DataSource = clients;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem1_ItemClick(object sender, EventArgs e)
        {
            



        }

        private void SaveClientButton_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}