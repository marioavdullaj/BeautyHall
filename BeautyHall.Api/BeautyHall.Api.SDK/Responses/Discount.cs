using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Discount
{
    public int ServiceId { get; set; }

    public int CustomerId { get; set; }

    public decimal DiscountPercentage { get; set; }

    public DateTime? DiscountTimestamp { get; set; }

    public Subject? Customer { get; set; } = null;
    public Service? Service { get; set; } = null;
}
