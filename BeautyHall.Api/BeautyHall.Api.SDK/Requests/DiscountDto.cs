namespace BeautyHall.Api.SDK.Requests
{
    public class DiscountDto
    {
        public int ServiceId { get; set; }
        public int CustomerId { get; set; }

        public decimal DiscountPercentage { get; set; } = 0;

        public DateTime? DiscountTimestamp { get; set; } = DateTime.Now;
    }
}
