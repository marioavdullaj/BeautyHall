using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class EmployeeDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; } = null!;
        [Required]
        public string? EmployeeLastName { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EmployeeRole { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? EmployeePhone { get; set; }

        public bool? IsActive { get; set; } = true;
    }
}
