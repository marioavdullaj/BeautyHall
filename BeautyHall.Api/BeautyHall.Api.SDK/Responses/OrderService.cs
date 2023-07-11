using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class OrderService
{
    public int OrderId { get; set; }

    public int ServiceId { get; set; }

    public decimal ServicePrice { get; set; }

    public int? EmployeeId { get; set; }

    public Employee? Employee { get; set; } = null;

    public Order? Order { get; set; } = null;

    public Service? Service { get; set; } = null;
}
