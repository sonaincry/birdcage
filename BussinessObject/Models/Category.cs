using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Category
{
    public int CateId { get; set; }

    public string? CateName { get; set; }

    public virtual ICollection<NewProduct> NewProducts { get; set; } = new List<NewProduct>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
