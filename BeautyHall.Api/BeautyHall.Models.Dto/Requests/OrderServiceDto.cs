﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Models.Dto.Requests
{
    public class OrderServiceDto
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public decimal ServicePrice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? EmployeeId { get; set; }
    }
}
