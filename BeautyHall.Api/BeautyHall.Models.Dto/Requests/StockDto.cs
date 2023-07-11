using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class StockDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public decimal Quantity { get; set; }
    }
}
