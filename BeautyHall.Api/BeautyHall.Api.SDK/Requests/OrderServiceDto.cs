namespace BeautyHall.Api.SDK.Requests
{
    public class OrderServiceDto
    {
        public int OrderId { get; set; }
        public int ServiceId { get; set; }
        public decimal ServicePrice { get; set; }

        public int? EmployeeId { get; set; }
    }
}
