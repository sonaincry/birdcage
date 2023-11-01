using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetOrderDetailById(string id);
        public void CreateNewOrderDetail(OrderDetail orderDetail);
        string GetMaxOrderDetailId();
    }
}
