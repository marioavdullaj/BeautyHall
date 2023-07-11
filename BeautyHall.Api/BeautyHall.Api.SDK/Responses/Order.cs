using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int? CustomerId { get; set; }

    public string? Notes { get; set; }

    public IEnumerable<OrderService> OrderServices { get; set; } = new List<OrderService>();

    public IEnumerable<PaymentSummary> PaymentSummaries { get; set; } = new List<PaymentSummary>();
    public IEnumerable<Appointment> Appointments { get; set; } = new List<Appointment>();

    public Subject? Customer { get; set; } = null;
}
