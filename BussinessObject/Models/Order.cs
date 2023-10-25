using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime? OrdDate { get; set; }

    public DateTime? Shipdate { get; set; }

    public int? Status { get; set; }

    public int? AccId { get; set; }

    public virtual Account? Acc { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
