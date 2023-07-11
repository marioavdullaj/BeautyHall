using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Discount
{
    public int ServiceId { get; set; }

    public int CustomerId { get; set; }

    public decimal DiscountPercentage { get; set; }

    public DateTime? DiscountTimestamp { get; set; }

    public virtual Subject Customer { get; set; } = null!;
    public virtual Service Service { get; set; } = null!;
}
