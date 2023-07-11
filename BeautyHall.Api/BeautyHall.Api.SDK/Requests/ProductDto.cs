namespace BeautyHall.Api.SDK.Requests
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public string? ProductDescription { get; set; }

        public int? SupplierId { get; set; }
    }
}
