using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Accessory
{
    public string AccessoryId { get; set; } = null!;

    public string? Name { get; set; }

    public double? Price { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
