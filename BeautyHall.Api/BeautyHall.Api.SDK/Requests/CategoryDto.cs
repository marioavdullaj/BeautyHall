using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace BeautyHall.Api.SDK.Requests
{
    public class CategoryDto
    {
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
    }
}