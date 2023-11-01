using BussinessObject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderDetailService : IOrderDetailService
    {

        private readonly IOrderDetailRepository orderDetailRepository;
        public OrderDetailService()
        {
            orderDetailRepository = new OrderDetailRepository();
        }

        public void CreateNewOrderDetail(OrderDetail orderDetail) => orderDetailRepository.CreateNewOrderDetail(orderDetail);

        public string GetMaxOrderDetailId() => orderDetailRepository.GetMaxOrderDetailId();

        public OrderDetail GetOrderDetailById(string id) => orderDetailRepository.GetOrderDetailById(id);
    }
}
