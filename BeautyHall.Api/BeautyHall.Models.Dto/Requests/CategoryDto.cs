using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BeautyHall.Models.Dto.Requests
{
    public class CategoryDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = null!;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? CategoryDescription { get; set; }
    }
}
