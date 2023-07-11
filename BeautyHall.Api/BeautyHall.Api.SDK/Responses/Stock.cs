using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Stock
{
    public int ProductId { get; set; }

    public decimal Quantity { get; set; }

    public Product? Product { get; set; } = null;
}
