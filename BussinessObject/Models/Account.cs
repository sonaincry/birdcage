using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Account
{
    public int AccId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Fullname { get; set; }

    public string? Phone { get; set; }

    public int? Status { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
