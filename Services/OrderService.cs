using BussinessObject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository orderRepository;
        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public void CreateNewOrder(Order order) => orderRepository.CreateNewOrder(order);

        public string GetMaxOrderId() => orderRepository.GetMaxOrderId();

        public Order GetOrderById(string id) => orderRepository.GetOrderById(id);
    }
}
