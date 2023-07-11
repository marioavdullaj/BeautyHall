using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Service
{
    public int ServiceId { get; set; }

    public string ServiceCode { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public string? ServiceNotes { get; set; }

    public decimal? ServiceMinimumPrice { get; set; }

    public decimal? ServiceMaximumPrice { get; set; }

    public IEnumerable<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
    public IEnumerable<Discount> Discounts { get; set; } = new List<Discount>();
    public Category? Category { get; set; } = null;
}
