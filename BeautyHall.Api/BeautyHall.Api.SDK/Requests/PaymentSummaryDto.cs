namespace BeautyHall.Api.SDK.Requests
{
    public class PaymentSummaryDto
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }

        public decimal? DiscountedPrice { get; set; } = 0;
        public decimal? TotalCash { get; set; } = 0;

        public decimal? TotalPOS { get; set; } = 0;

        public DateTime? PaymentDate { get; set; } = DateTime.Now;
    }
}
