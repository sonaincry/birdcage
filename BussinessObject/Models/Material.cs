using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Material
{
    public int MaterialId { get; set; }

    public string? MaterialName { get; set; }

    public virtual ICollection<NewProduct> NewProducts { get; set; } = new List<NewProduct>();
}
