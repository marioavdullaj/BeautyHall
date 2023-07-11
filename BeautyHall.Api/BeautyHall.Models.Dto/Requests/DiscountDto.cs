using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class DiscountDto
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public decimal DiscountPercentage { get; set; } = 0;

        public DateTime? DiscountTimestamp { get; set; } = DateTime.Now;
    }
}
