using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class ProductDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ProductDescription { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; }
    }
}
