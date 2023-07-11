using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class OrderService
{
    public int OrderId { get; set; }

    public int ServiceId { get; set; }

    public decimal ServicePrice { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
