using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class CartDetail
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double SumPrice { get; set; }
    }
}
