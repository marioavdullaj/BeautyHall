using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string? EmployeeLastName { get; set; }

    public string? EmployeeRole { get; set; }

    public string? EmployeePhone { get; set; }

    public bool? IsActive { get; set; }

    public string? EmployeeEmail { get; set; }

    public DateTime? EmployeeRegistrationDate { get; set; }

    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
