using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class LoginDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Surname { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Role { get; set; }
    }
}
