﻿using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceCode { get; set; } = null!;

    public string? ServiceDescription { get; set; }

    public string? ServiceNotes { get; set; }

    public decimal? ServiceMinimumPrice { get; set; }

    public decimal? ServiceMaximumPrice { get; set; }
    public int? CategoryId { get; set; }

    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();
    public virtual Category? Category { get; set; }
}
