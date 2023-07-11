namespace BeautyHall.Api.SDK.Requests
{
    public class OrderDto
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int? CustomerId { get; set; }

        public string? Notes { get; set; }

        public IEnumerable<OrderServiceDto>? Services { get; set; }
    }
}
