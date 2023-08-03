using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int? CustomerId { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<OrderService> OrderServices { get; set; } = new List<OrderService>();
    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual ICollection<PaymentSummary> PaymentSummaries { get; set; } = new List<PaymentSummary>();
    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Subject? Customer { get; set; } = null;
}
