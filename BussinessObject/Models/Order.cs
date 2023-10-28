using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public double? Total { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual User? User { get; set; }
}
