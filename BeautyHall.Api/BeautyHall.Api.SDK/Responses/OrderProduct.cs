using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class OrderProduct
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public decimal ProductQuantity { get; set; }

    public decimal TotalPrice { get; set; }

    public Order? Order { get; set; } = null;

    public Product? Product { get; set; } = null;
}
