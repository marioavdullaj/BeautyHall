namespace BeautyHall.Api.SDK.Requests
{
    public class OrderProductDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal ProductQuantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
