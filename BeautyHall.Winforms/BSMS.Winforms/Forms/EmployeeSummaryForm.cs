using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts.Design;
using System.Data;
using BSMS.Winforms.GenericUtils;
using BSMS.Winforms.Utils;
using DevExpress.DataAccess.Native.Data;
using BSMS.Winforms.UserControls;
using DevExpress.DocumentView.Controls;
using BSMS.Winforms.Forms;



namespace BSMS.Winforms.Forms
{
    public partial class EmployeeSummaryForm : FixedRibbonForm
    {
        private IEnumerable<BeautyHall.Api.SDK.Responses.Employee>? employees;
        private IEnumerable<BeautyHall.Api.SDK.Responses.Order>? allOrders;
        private List<EmployeeSummaryControl> serviceControls = new List<EmployeeSummaryControl>();

        // Declare the dictionary at the class level
        private Dictionary<int, Dictionary<int, string>> employeeServiceIdToTextEditName = new Dictionary<int, Dictionary<int, string>>
        {
            // Mapping for Employee 6
            { 6, new Dictionary<int, string> { { 1, "textEdit10" }, { 9, "textEdit9" }, { 11, "textEdit11" }, { 12, "textEdit12" }, { 25, "textEdit25" }, { 26, "textEdit26" } } },

            // Mapping for Employee 9
            { 9, new Dictionary<int, string> { { 1, "textEdit1" }, { 2, "textEdit2" }, { 3, "textEdit3" }, { 5, "textEdit5" }, { 6, "textEdit6" }, { 7, "textEdit7" }, { 8, "textEdit8" } } },

            // Mapping for Employee 10
            { 10, new Dictionary<int, string> { { 13, "textEdit13" }, { 14, "textEdit14" }, { 15, "textEdit15" }, { 16, "textEdit19" }, { 17, "textEdit20" }, { 18, "textEdit21" }, { 19, "textEdit17" }, { 20, "textEdit22" }, { 21, "textEdit23" }, { 22, "textEdit28" }, { 23, "textEdit24" }, { 24, "textEdit27" }, { 27, "textEdit16" }, { 28, "textEdit18" } } }

            // Add more mappings as needed for other employees
        };

        public EmployeeSummaryForm()
        {
            InitializeComponent();
        }

        private async Task LoadAllOrders()
        {
            try
            {
                // Fetch all orders (replace with your actual API call)
                allOrders = await Program.ApiSdk.GetOrders();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void EmployeeSummaryForm_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = new DateTime(2023, 4, 4);
            dateTo.EditValue = DateTime.Today;
            try
            {
                employees = await Program.ApiSdk.GetEmployees();

                if (employees != null)
                {
                    var employeeList = employees.Select(x => new Models.Employee
                    {
                        Id = x.EmployeeId,
                        Surname = x.EmployeeLastName,
                        Name = x.EmployeeName,
                        Code = x.EmployeeCode,
                    }).ToList();

                    lueEmployee.Properties.DataSource = employeeList;
                    lueEmployee.Properties.DisplayMember = "Name";
                    lueEmployee.Properties.ValueMember = "Id";
                }

                await LoadAllOrders(); // Load orders here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lueEmployee_EditValueChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();

            try
            {
                // Get the selected date range from the DateEdit controls
                DateTime startDate = dateFrom.DateTime.Date;
                DateTime endDate = dateTo.DateTime.Date;

                // Get the selected employee ID from the LookupEdit
                int selectedEmployeeId = (int)lueEmployee.EditValue;

                // Fetch the total service count for the selected employee
                int totalServiceCount = GetTotalServiceCountForEmployee(selectedEmployeeId, startDate, endDate);

                // Set the txtServiceCount control with the total service count
                txtServiceCount.EditValue = totalServiceCount.ToString();

                string connectionString = "Data Source=MANDISPRO11\\SQLEXPRESS;Initial Catalog=BeautyHall;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = @"
                    SELECT 
                        o.OrderId,
                        o.OrderDate,
                        c.SubjectLastName,
                        s.ServiceId,
                        s.ServiceDescription,
                        os.ServicePrice AS TotalPrice,
                        es.EmployeeId AS EmployeeId,
                        e.EmployeeCode AS EmployeeCode
                    FROM 
                        [dbo].[Order] o
                    JOIN 
                        [dbo].[Order_Service] os ON o.OrderId = os.OrderId
                    JOIN 
                        [dbo].[Service] s ON os.ServiceId = s.ServiceId
                    JOIN 
                        [dbo].[Subject] c ON o.CustomerId = c.SubjectId
                    JOIN 
                        [dbo].[Employee_Service] es ON s.ServiceId = es.ServiceId
                    JOIN 
                        [dbo].[Employee] e ON es.EmployeeId = e.EmployeeId
                    WHERE 
                        es.EmployeeId = @EmployeeId
                        AND o.OrderDate BETWEEN @StartDate AND @EndDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", selectedEmployeeId);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataReader reader = await command.ExecuteReaderAsync();

                        dataTable.Load(reader); // Load the data into the DataTable

                        // Bind the DataTable to the grid control
                        gcEmployee.DataSource = dataTable;

                        reader.Close();
                    }

                }
                // Update employee information
                UpdateEmployeeInfo(selectedEmployeeId);

                // Update TextEdit controls
                UpdateTextEditControls(selectedEmployeeId, dataTable);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateTextEditControls(int selectedEmployeeId, System.Data.DataTable dataTable)
        {
            // Initialize the total summary
            decimal totalSummary = 0;

            // Iterate through TextEdit controls and update based on distinct serviceId list
            foreach (var kvp in employeeServiceIdToTextEditName[selectedEmployeeId])
            {
                int serviceId = kvp.Key;
                string textEditName = kvp.Value;
                var textField = this.Controls.Find(textEditName, true).FirstOrDefault() as TextEdit;

                if (dataTable.AsEnumerable().Any(row => row.Field<int>("ServiceId") == serviceId))
                {
                    // Service is present in the selected date range, update TextEdit with total price
                    decimal totalPrice = dataTable.AsEnumerable()
                        .Where(row => row.Field<int>("ServiceId") == serviceId)
                        .Sum(row => row.Field<decimal>("TotalPrice"));
                    textField.EditValue = totalPrice.ToString("F2");

                    // Add the service's total price to the total summary
                    totalSummary += totalPrice;
                }
                else
                {
                    // Service is not present in the selected date range, set TextEdit to empty
                    textField.EditValue = string.Empty;
                }
            }

            // Update the TextEdit control for the total summary
            string totalSummaryTextEditName = $"txtTotalSummary{selectedEmployeeId}";
            var totalSummaryField = this.Controls.Find(totalSummaryTextEditName, true).FirstOrDefault() as TextEdit;
            if (totalSummaryField != null)
            {
                totalSummaryField.EditValue = totalSummary.ToString("F2");
            }
        }

        private void UpdateEmployeeInfo(int selectedEmployeeId)
        {
            // Find the selected employee in the list
            var selectedEmployee = employees?.FirstOrDefault(x => x.EmployeeId == selectedEmployeeId);
            if (selectedEmployee != null)
            {
                txteEmployeeId.EditValue = selectedEmployee.EmployeeId;
                txteSurname.EditValue = selectedEmployee.EmployeeLastName;
                txteName.EditValue = selectedEmployee.EmployeeName;
                txtePhone.EditValue = selectedEmployee.EmployeePhone;
                txteEmail.EditValue = selectedEmployee.EmployeeEmail;
                txteRegDate.EditValue = selectedEmployee.EmployeeRegistrationDate ?? DateTime.MinValue;
                txteEmployeeCode.EditValue = selectedEmployee.EmployeeCode;
            }
        }
        // Define a method to fetch the total service count for the selected employee
        private int GetTotalServiceCountForEmployee(int employeeId, DateTime startDate, DateTime endDate)
        {
            int totalServiceCount = 0;
            string connectionString = "Data Source=MANDISPRO11\\SQLEXPRESS;Initial Catalog=BeautyHall;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
                            COUNT(*) AS TotalServiceCount
                        FROM 
                            [dbo].[Order] o
                        JOIN 
                            [dbo].[Order_Service] os ON o.OrderId = os.OrderId
                        JOIN 
                            [dbo].[Service] s ON os.ServiceId = s.ServiceId
                        JOIN 
                            [dbo].[Employee_Service] es ON s.ServiceId = es.ServiceId
                        WHERE 
                            es.EmployeeId = @EmployeeId
                            AND o.OrderDate BETWEEN @StartDate AND @EndDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        totalServiceCount = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here (e.g., display an error message)
                MessageBox.Show("Error fetching total service count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return totalServiceCount;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}



