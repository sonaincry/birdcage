using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public int? Price { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public int? CateId { get; set; }

    public virtual Category? Cate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
