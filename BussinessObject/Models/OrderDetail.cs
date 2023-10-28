using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class OrderDetail
{
    public string OrderDetailId { get; set; } = null!;

    public string? ProductId { get; set; }

    public string? OrderId { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
