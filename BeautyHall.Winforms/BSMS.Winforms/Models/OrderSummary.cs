using BeautyHall.Api.SDK.Responses;

namespace BSMS.Winforms.Models
{
    public class OrderSummary
    {
        public int Id { get; set; }
        public string? CustomerFullName { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public bool? ExistProductsInOrder { get; set; }
        public IEnumerable<OrderProduct>? ProductsInOrder { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool Payed { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string DiscountPercentage { get; set; }
        public decimal? TotalCash { get; set; }
        public decimal? TotalPOS { get; set; }
        
    }
}
