using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class PaymentSummary
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal? DiscountedPrice { get; set; }
    public decimal? TotalCash { get; set; }

    public decimal? TotalPOS { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}
