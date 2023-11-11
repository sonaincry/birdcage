using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public static class UserInfo
    {
        public static string UserId { get; set; } = null!;

        public static string? Email { get; set; }

        public static string? Password { get; set; }

        public static string? Fullname { get; set; }

        public static int? Role { get; set; }

        public static string? Address { get; set; }

        public static string? Phone { get; set; }

        public static DateTime? CreatedDate { get; set; }

        //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
