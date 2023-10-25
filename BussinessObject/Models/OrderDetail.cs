using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class OrderDetail
{
    public int DetailId { get; set; }

    public int? OrderId { get; set; }

    public int? Pid { get; set; }

    public int? Quantity { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? PidNavigation { get; set; }
}
