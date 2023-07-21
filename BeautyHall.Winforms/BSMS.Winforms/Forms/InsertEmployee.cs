<<<<<<< HEAD
﻿using BSMS.Winforms.GenericUtils;
using DevExpress.XtraBars;
=======
﻿using DevExpress.XtraBars;
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using BeautyHall.Api.SDK.Responses;
using Demo;
using BSMS.Winforms.Models;
using DevExpress.Utils.Extensions;
using Demo.UserControls;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using BSMS.Winforms.UserControls;
=======
using BSMS.Winforms.GenericUtils;
using BeautyHall.Api.SDK.Responses;
using Demo;
using BSMS.Winforms.Models;
using BeautyHall.Api.SDK.Requests;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Native;

>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84

namespace BSMS.Winforms.Forms
{
    public partial class InsertEmployee : FixedRibbonForm
    {
<<<<<<< HEAD
=======
        private IEnumerable<BeautyHall.Api.SDK.Responses.Employee>? employees;

>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
        public InsertEmployee()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======


        private void EnableClientButtons(bool enable)
        {
            EmployeeHeaderPanel.Enabled = enable;
            SaveEmployeeButton.Enabled = enable;
            CancelEmployeeButton.Enabled = enable;
            //EditEmployeeButton.Enabled = enable;
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

        private async Task LoadEmployee()
        {
            try
            {
                employees = await Program.ApiSdk.GetEmployees();
                if (employees != null)
                {
                    var employee = employees.Where(x => x.EmployeeId == 0).Select(x => new Customer
                    {
                        Id = x.EmployeeId,
                        Surname = x.EmployeeLastName,
                        Name = x.EmployeeName,
                        Tel = x.EmployeePhone,
                        //Email = x.EmployeeEmail
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
                        //EmployeeEmail= textEdit5.Text,
                        //EmployeeRegistrationDate = dateEdit1.DateTime
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
                    XtraMessageBox.Show("Error durig registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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
                    //textEdit5.EditValue = selectedEmployees.EmployeeEmail;
                    //dateEdit1.DateTime = selectedEmployees.EmployeeRegistrationDate ?? DateTime.MinValue;

                    EnableClientButtons(true);
                }
            }
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
                if (await DeleteSubject(selectedEmployee))
                {
                    Clear();
                    EnableClientButtons(false);
                    await LoadEmployee();
                }
            }
        }

        private async Task<bool> DeleteSubject(BeautyHall.Api.SDK.Responses.Employee? employee)
        {
            try
            {
                if (employee != null)
                {
                    if (await Program.ApiSdk.DeleteSubject(employee.EmployeeId))
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
>>>>>>> d5073bb563845b48499ac078516cf60c86a8ff84
    }
}