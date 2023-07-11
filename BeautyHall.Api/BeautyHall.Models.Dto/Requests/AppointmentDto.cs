using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class AppointmentDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int AppointmentId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        public int AppointmentStatus = 0;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int OrderId { get; set; }
    }
}
