using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class NewProduct
{
    public int Idpro { get; set; }

    public int? CateId { get; set; }

    public int? MaterialId { get; set; }

    public string? Pname { get; set; }

    public string? Size { get; set; }

    public string? Materiel { get; set; }

    public int? Cost { get; set; }

    public string? Description { get; set; }

    public virtual Category? Cate { get; set; }

    public virtual Material? Material { get; set; }
}
