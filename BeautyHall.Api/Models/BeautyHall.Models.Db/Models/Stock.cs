using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Stock
{
    public int ProductId { get; set; }

    public decimal Quantity { get; set; }

    public virtual Product Product { get; set; } = null!;
}
