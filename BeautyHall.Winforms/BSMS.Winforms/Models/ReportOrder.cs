namespace BSMS.Winforms.Models
{
    public class ReportOrder
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? ServiceId { get; set; }
        public string? ServiceDescription { get; set; }
        public string? EmployeeCode { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalCash { get; set; }
        public decimal? TotalPOS { get; set; }
        public decimal? DiscountedPrice { get; set; }
    }
}
