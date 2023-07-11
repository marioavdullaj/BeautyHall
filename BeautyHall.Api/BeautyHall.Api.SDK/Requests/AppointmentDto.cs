namespace BeautyHall.Api.SDK.Requests
{
    public class AppointmentDto
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int AppointmentStatus = 0;
        public int OrderId { get; set; }
    }
}
