using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Product
{
    public string ProductId { get; set; } = null!;

    public string? Name { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public int? Spoke { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Accessory> Accessories { get; set; } = new List<Accessory>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
