using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetOrderById(string id) => OrderDAO.Instance.GetOrderById(id);
        public void CreateNewOrder(Order order) => OrderDAO.Instance.CreateNewOrder(order);
        public string GetMaxOrderId() => OrderDAO.Instance.GetMaxOrderId();
    }
}
