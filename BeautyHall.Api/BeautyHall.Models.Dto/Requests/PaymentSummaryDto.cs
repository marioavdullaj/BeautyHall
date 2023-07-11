using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class PaymentSummaryDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int PaymentId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public decimal? DiscountedPrice { get; set; } = 0;
        public decimal? TotalCash { get; set; } = 0;

        public decimal? TotalPOS { get; set; } = 0;

        public DateTime? PaymentDate { get; set; } = DateTime.Now;
    }
}
