using DevExpress.XtraBars;
using System.Data;
using BSMS.Winforms.GenericUtils;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;

namespace BSMS.Winforms.Forms
{
    public partial class EmployeeForm : FixedRibbonForm
    {
        private IEnumerable<BeautyHall.Api.SDK.Responses.Employee>? employees;

        public EmployeeForm()
        {
            InitializeComponent();
        }


        private void EnableClientButtons(bool enable)
        {
            EmployeeHeaderPanel.Enabled = enable;
            SaveEmployeeButton.Enabled = enable;
            CancelEmployeeButton.Enabled = enable;
            barButtonItem4.Enabled = enable;
            //EditEmployeeButton.Enabled = enable;
        }

        private void Clear()
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            employeeCodeTxt.Text = "";
            dateEdit1.DateTime = DateTime.Now;
        }

        private async Task LoadEmployee()
        {
            try
            {
                employees = await Program.ApiSdk.GetEmployees();
                if (employees != null)
                {
                    var employee = employees.Select(x => new Models.Employee
                    {
                        Id = x.EmployeeId,
                        Surname = x.EmployeeLastName,
                        Name = x.EmployeeName,
                        Tel = x.EmployeePhone,
                        Email = x.EmployeeEmail,
                        RegistrationDate = x.EmployeeRegistrationDate,
                        Code = x.EmployeeCode
                    });

                    gridControl1.DataSource = employee;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void InsertEmployee_Load(object sender, EventArgs e)
        {
            EnableClientButtons(false);
            try
            {
                dateEdit1.DateTime = DateTime.Now;
                await LoadEmployee();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> InsertNewEmployee()
        {
            try
            {
                var subjectId = Functions.NullToInt(textEdit2.EditValue);
                var input = new List<EmployeeDto>
                {
                    new EmployeeDto
                    {
                        EmployeeId = subjectId,
                        EmployeeLastName = textEdit1.Text,
                        EmployeeName = textEdit3.Text,
                        EmployeePhone = textEdit4.Text,
                        EmployeeEmail= textEdit5.Text,
                        EmployeeRegistrationDate = dateEdit1.DateTime,
                        EmployeeCode = employeeCodeTxt.Text
                    }
                };
                bool result = await Program.ApiSdk.UpsertEmployees(input);

                if (result)
                {
                    XtraMessageBox.Show(subjectId == 0 ? "New employee is register!" : "Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Error during registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void CancelEmployeeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
            EnableClientButtons(false);
        }

        private async void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selected = gridView1.GetSelectedRows();
            if (selected != null && selected.Any())
            {
                var selectedEmployee = employees?.ElementAt(selected[0]);
                if (await DeleteEmployee(selectedEmployee))
                {
                    Clear();
                    EnableClientButtons(false);
                    await LoadEmployee();
                }
            }
        }

        private async Task<bool> DeleteEmployee(BeautyHall.Api.SDK.Responses.Employee? employee)
        {
            try
            {
                if (employee != null)
                {
                    if (await Program.ApiSdk.DeleteEmployee(employee.EmployeeId))
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

        private async void SaveEmployeeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (await InsertNewEmployee())
            {
                // Clear all the user controls and disable
                Clear();
                EnableClientButtons(false);
                await LoadEmployee();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
            EnableClientButtons(true);
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            // here when we select a row we autocompile the data in the above panel
            var selected = gridView1.GetSelectedRows();
            if (selected != null && selected.Any())
            {
                var selectedEmployees = employees?.ElementAt(selected[0]);
                if (selectedEmployees != null)
                {
                    textEdit2.EditValue = selectedEmployees.EmployeeId;
                    textEdit1.EditValue = selectedEmployees.EmployeeLastName;
                    textEdit3.EditValue = selectedEmployees.EmployeeName;
                    textEdit4.EditValue = selectedEmployees.EmployeePhone;
                    textEdit5.EditValue = selectedEmployees.EmployeeEmail;
                    dateEdit1.DateTime = selectedEmployees.EmployeeRegistrationDate ?? DateTime.MinValue;
                    employeeCodeTxt.Text = selectedEmployees.EmployeeCode;

                    EnableClientButtons(true);
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e) => this.Close();
    }
}