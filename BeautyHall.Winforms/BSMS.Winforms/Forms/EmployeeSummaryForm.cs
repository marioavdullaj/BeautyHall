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

namespace BSMS.Winforms.Forms
{
    public partial class EmployeeSummaryForm : FixedRibbonForm
    {
        private IEnumerable<BeautyHall.Api.SDK.Responses.Employee>? employees;
        private IEnumerable<Order>? allOrders;
        private IEnumerable<Order>? GetOrders;


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

                string connectionString = "Data Source=MANDISPRO11\\SQLEXPRESS;Initial Catalog=BeautyHall;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                // Define the dictionary to map EmployeeId -> ServiceId -> TextEditName
                Dictionary<int, Dictionary<int, string>> employeeServiceIdToTextEditName = new Dictionary<int, Dictionary<int, string>>
                {
                    // Mapping for Employee 6
                    { 6, new Dictionary<int, string> { { 9, "textEdit9" }, { 11, "textEdit11" }, { 12, "textEdit12" }, { 25, "textEdit25" }, { 26, "textEdit26" } } },
            
                    // Mapping for Employee 9
                    { 9, new Dictionary<int, string> { { 1, "textEdit1" }, { 2, "textEdit2" }, { 3, "textEdit3" }, { 5, "textEdit5" }, { 6, "textEdit6" } } },
            
                    // Mapping for Employee 10
                    { 10, new Dictionary<int, string> { { 13, "textEdit13" }, { 14, "textEdit14" }, { 15, "textEdit15" }, { 16, "textEdit16" }, { 17, "textEdit17" } } }
            
                    // Add more mappings as needed for other employees
                };

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Get the selected employee ID from the LookupEdit
                    int selectedEmployeeId = (int)lueEmployee.EditValue;

                    string query = @"
                        SELECT 
                            o.OrderId,
                            o.OrderDate,
                            c.SubjectLastName,
                            s.ServiceId,
                            s.ServiceDescription,
                            os.ServicePrice AS TotalPrice
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

                    // Create a list of distinct serviceId values for the selected date range
                    List<int> distinctServiceIds = dataTable.AsEnumerable()
                        .Where(row => row.Field<int>("ServiceId") != 0) // Filter out rows with empty ServiceId
                        .Select(row => row.Field<int>("ServiceId"))
                        .Distinct()
                        .ToList();

                    // Iterate through TextEdit controls and update based on distinct serviceId list
                    foreach (var kvp in employeeServiceIdToTextEditName[selectedEmployeeId])
                    {
                        int serviceId = kvp.Key;
                        string textEditName = kvp.Value;
                        var textField = this.Controls.Find(textEditName, true).FirstOrDefault() as TextEdit;

                        if (distinctServiceIds.Contains(serviceId))
                        {
                            // Service is present in the selected date range, update TextEdit with total price
                            decimal totalPrice = dataTable.AsEnumerable()
                                .Where(row => row.Field<int>("ServiceId") == serviceId)
                                .Sum(row => row.Field<decimal>("TotalPrice"));
                            textField.EditValue = totalPrice.ToString("F2");
                        }
                        else
                        {
                            // Service is not present in the selected date range, set TextEdit to empty
                            textField.EditValue = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error loading orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}


