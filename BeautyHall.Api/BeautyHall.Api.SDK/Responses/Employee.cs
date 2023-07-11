using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? EmployeeLastName { get; set; }

    public string? EmployeeRole { get; set; }

    public string? EmployeePhone { get; set; }

    public bool? IsActive { get; set; }

    public IEnumerable<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public IEnumerable<Service> Services { get; set; } = new List<Service>();
}
