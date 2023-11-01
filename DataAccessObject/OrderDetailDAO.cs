using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;

        public OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }

        public OrderDetail GetOrderDetailById(string id)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                return dbContext.OrderDetails.SingleOrDefault(m => m.OrderDetailId.Equals(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetMaxOrderDetailId()
        {
            try
            {
                using (var dbContext = new BirdCageShopContext())
                {
                    var maxOrderDetailId = dbContext.OrderDetails
                        .Where(o => o.OrderDetailId.StartsWith("ODT"))
                        .OrderByDescending(o => o.OrderDetailId)
                        .Select(o => o.OrderDetailId)
                        .FirstOrDefault();

                    return maxOrderDetailId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving max order detail ID: " + ex.Message);
            }
        }

        public void CreateNewOrderDetail(OrderDetail newOrderDetail)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                OrderDetail order = GetOrderDetailById(newOrderDetail.OrderDetailId);
                if (order == null)
                {
                    dbContext.OrderDetails.Add(newOrderDetail);
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
