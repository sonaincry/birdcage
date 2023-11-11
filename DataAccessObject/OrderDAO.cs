using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;

        public OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }

        public Order GetOrderById(string id)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                return dbContext.Orders.SingleOrDefault(m => m.OrderId.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetOrderByUserIdOrPhone(string userId, string phoneNumber)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                return dbContext.Orders.Where(m => m.UserId.Equals(userId) || m.Phone.Equals(phoneNumber)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetMaxOrderId()
        {
            try
            {
                using (var dbContext = new BirdCageShopContext())
                {
                    var maxOrderId = dbContext.Orders
                        .Where(o => o.OrderId.StartsWith("OD"))
                        .OrderByDescending(o => o.OrderId)
                        .Select(o => o.OrderId)
                        .FirstOrDefault();

                    return maxOrderId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving max order ID: " + ex.Message);
            }
        }

        public void CreateNewOrder(Order newOrder)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                Order order = GetOrderById(newOrder.OrderId);
                if (order == null)
                {
                    dbContext.Orders.Add(newOrder);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
