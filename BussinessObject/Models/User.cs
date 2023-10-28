using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Fullname { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
