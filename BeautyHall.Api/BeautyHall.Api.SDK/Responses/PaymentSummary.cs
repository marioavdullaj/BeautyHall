using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class PaymentSummary
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal? TotalCash { get; set; }

    public decimal? TotalPOS { get; set; }
    public decimal? DiscountedPrice { get; set; }

    public DateTime? PaymentDate { get; set; }

    public Order? Order { get; set; } = null;
}
