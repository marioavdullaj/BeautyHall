using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BeautyHall.Models.Dto.Requests
{
    public class ServiceDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int ServiceId { get; set; }
        [MaxLength(100)]
        public string ServiceCode { get; set; } = null!;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDescription { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNotes { get; set; }

        public decimal? ServiceMinimumPrice { get; set; } = 0;

        public decimal? ServiceMaximumPrice { get; set; } = 0;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }
    }
}
