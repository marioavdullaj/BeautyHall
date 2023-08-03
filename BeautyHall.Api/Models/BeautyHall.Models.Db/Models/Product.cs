using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductDescription { get; set; }

    public int? SupplierId { get; set; }
    public decimal? SellingPrice { get; set; }

    public virtual Stock? Stock { get; set; }

    public virtual Subject? Supplier { get; set; }
    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
