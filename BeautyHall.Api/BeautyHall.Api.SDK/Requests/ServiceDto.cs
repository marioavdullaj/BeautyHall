namespace BeautyHall.Api.SDK.Requests
{
    public class ServiceDto
    {
        public int ServiceId { get; set; }
        public string ServiceCode { get; set; } = null!;

        public string? ServiceDescription { get; set; }

        public string? ServiceNotes { get; set; }

        public decimal? ServiceMinimumPrice { get; set; } = 0;

        public decimal? ServiceMaximumPrice { get; set; } = 0;
        public int? CategoryId { get; set; } = 0;
    }
}
