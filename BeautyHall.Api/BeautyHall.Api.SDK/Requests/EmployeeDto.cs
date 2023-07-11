namespace BeautyHall.Api.SDK.Requests
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? EmployeeLastName { get; set; }
        public string? EmployeeRole { get; set; }
        public string? EmployeePhone { get; set; }
        public bool? IsActive { get; set; } = true;
    }
}
