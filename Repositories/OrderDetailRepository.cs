using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public OrderDetail GetOrderDetailById(string id) => OrderDetailDAO.Instance.GetOrderDetailById(id);
        public void CreateNewOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.CreateNewOrderDetail(orderDetail);
        public string GetMaxOrderDetailId() => OrderDetailDAO.Instance.GetMaxOrderDetailId();
    }
}
