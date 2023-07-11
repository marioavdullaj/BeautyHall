using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Product
{
    public int ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ProductDescription { get; set; }

    public int? SupplierId { get; set; }

    public Stock? Stock { get; set; }

    public Subject? Supplier { get; set; }
}
