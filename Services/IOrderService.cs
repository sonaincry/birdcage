using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IOrderService
    {
        Order GetOrderById(string id);
        public void CreateNewOrder(Order order);
        string GetMaxOrderId();
        List<Order> GetOrderByUserIdOrPhone(string userId, string phoneNumber);
        List<Order> GetOrders();
    }
}
