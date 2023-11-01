using BussinessObject;
using BussinessObject.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdCageManagement
{
    public partial class CheckoutForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        public CheckoutForm()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _orderDetailService = new OrderDetailService();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                foreach (var detail in Cart.CartDetails)
                {
                    total += detail.SumPrice;
                }
                string maxOrderId = _orderService.GetMaxOrderId();
                int currentNumber = int.Parse(maxOrderId.Substring(2));
                int newNumber = currentNumber + 1;
                string newOrderNumber = newNumber.ToString("D2");

                Order order = new Order();
                order.Total = total;
                order.Phone = txtPhoneNumber.Text.Trim();
                order.Address = txtAddress.Text.Trim();
                order.CreatedDate = DateTime.Now;
                order.Status = 0;
                order.OrderId = "OD" + newNumber;

                foreach (var detail in Cart.CartDetails)
                {
                    string maxOrderDetailId = _orderDetailService.GetMaxOrderDetailId();
                    int cNumber = int.Parse(maxOrderDetailId.Substring(3));
                    int newDTNumber = cNumber + 1;
                    string newOrderDetailNumber = newDTNumber.ToString("D2");
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderDetailId = "ODT" + newOrderDetailNumber,
                        ProductId = detail.Product.ProductId,
                        OrderId = order.OrderId,
                        Quantity = detail.Quantity,
                        Price = (int?)detail.SumPrice,
                        //Product = detail.Product,
                    };
                    order.OrderDetails.Add(orderDetail);
                    //_orderDetailService.CreateNewOrderDetail(orderDetail);
                }

                _orderService.CreateNewOrder(order);

                foreach (var detail in order.OrderDetails)
                {
                    _orderDetailService.CreateNewOrderDetail(detail);
                }
                MessageBox.Show("Ordered Successfully! Please wait 2-3 days for the delivery.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
