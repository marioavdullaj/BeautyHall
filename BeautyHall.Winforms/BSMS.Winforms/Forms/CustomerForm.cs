using BSMS.Winforms.GenericUtils;
using DevExpress.XtraBars;
using System.Data;
using BeautyHall.Api.SDK.Responses;
using BSMS;
using BSMS.Winforms.Models;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;
using DevExpress.XtraGrid.Columns;

namespace BSMS.Winforms.Forms
{
    public partial class CustomerForm : FixedRibbonForm
    {
        private IEnumerable<Subject>? subjects;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void EnableClientButtons(bool enable)
        {
            ClientHeaderPanel.Enabled = enable;
            SaveClientButton.Enabled = enable;
            CancelClientButton.Enabled = enable;
            EditClientButton.Enabled = enable;
            barButtonItem2.Enabled = enable;
            
        }
        private async void InsertClient_Load(object sender, EventArgs e)
        {
            EnableClientButtons(false);
            try
            {
                dateEdit1.DateTime = DateTime.Now;
                await LoadSubjects();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadSubjects()
        {
            try
            {
                subjects = await Program.ApiSdk.GetSubjects();
                if (subjects != null)
                {
                    var clients = subjects.Where(x => x.SubjectType == 0).Select(x => new Customer
                    {
                        Id = x.SubjectId,
                        Surname = x.SubjectLastName,
                        Name = x.SubjectName,
                        Tel = x.PhoneNumber
                        
                    });
                    lookUpEdit1.Properties.DataSource = clients;
                    lookUpEdit1.Properties.DisplayMember = "Surname";
                    lookUpEdit1.Properties.ValueMember = "Id";
                    gridControl1.DataSource = clients;
                }


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
            EnableClientButtons(true);
        }

        private async Task<bool> InsertNewClient()
        {
            try
            {
                var subjectId = Functions.NullToInt(textEdit2.EditValue);
                var input = new List<SubjectDto>
                {
                    new SubjectDto
                    {
                        SubjectId = subjectId,
                        SubjectLastName = textEdit1.Text,
                        SubjectName = textEdit3.Text,
                        PhoneNumber = textEdit4.Text,
                        EMail = textEdit5.Text,
                        RegistrationDate = dateEdit1.DateTime
                    }
                };
                bool result = await Program.ApiSdk.UpsertSubjects(input);

                if (result)
                {
                    XtraMessageBox.Show(subjectId == 0 ? "New customer is register!" : "Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Error durig registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private async void SaveClientButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (await InsertNewClient())
            {
                // Clear all the user controls and disable
                Clear();
                EnableClientButtons(false);
                await LoadSubjects();
            }
        }

        private void Clear()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            dateEdit1.DateTime = DateTime.Now;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedRowHandle = gridView1.FocusedRowHandle;
            var selectedCustomer = gridView1.GetRow(selectedRowHandle) as Customer;

            if (selectedCustomer != null)
            {
                textEdit2.EditValue = selectedCustomer.Id;
                textEdit1.EditValue = selectedCustomer.Surname;
                textEdit3.EditValue = selectedCustomer.Name;
                textEdit4.EditValue = selectedCustomer.Tel;
                textEdit5.EditValue = selectedCustomer.Email;
                dateEdit1.DateTime = DateTime.Now;

                EnableClientButtons(true);
            }
            
        }

        private void CancelClientButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
            EnableClientButtons(false);
        }

        private async void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            var selected = gridView1.GetSelectedRows();
            if (selected != null && selected.Any())
            {
                var selectedCustomer = subjects?.ElementAt(selected[0]);
                if (await DeleteSubject(selectedCustomer))
                {
                    Clear();
                    EnableClientButtons(false);
                    await LoadSubjects();
                }
            }
        }

        private async Task<bool> DeleteSubject(Subject? subject)
        {
            try
            {
                if (subject != null)
                {
                    if (await Program.ApiSdk.DeleteSubject(subject.SubjectId))
                    {
                        XtraMessageBox.Show("Customer removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Error during cancellation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("No customer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

        private async void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
            int selectedCustomerId = (int)lookUpEdit1.EditValue;

            var selectedCustomer = subjects?.FirstOrDefault(x => x.SubjectId == selectedCustomerId);
            if (selectedCustomer != null)
            {
                var selectedCustomerList = new List<Customer>
                {
                   new Customer
                   {
                      Id = selectedCustomer.SubjectId,
                      Surname = selectedCustomer.SubjectLastName,
                      Name = selectedCustomer.SubjectName,
                      Tel = selectedCustomer.PhoneNumber,
                      Email = selectedCustomer.Email
                   }
                };

                gridControl1.DataSource = selectedCustomerList;
                gridControl1.RefreshDataSource();

                // Populate text fields
                textEdit2.EditValue = selectedCustomer.SubjectId;
                textEdit1.EditValue = selectedCustomer.SubjectLastName;
                textEdit3.EditValue = selectedCustomer.SubjectName;
                textEdit4.EditValue = selectedCustomer.PhoneNumber;
                textEdit5.EditValue = selectedCustomer.Email;
                dateEdit1.DateTime = selectedCustomer.RegistrationDate ?? DateTime.MinValue;
            }
            
        }
    }
}