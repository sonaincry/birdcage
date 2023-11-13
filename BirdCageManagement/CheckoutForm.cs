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
using System.Text.RegularExpressions;
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
                bool isValid = false;
                if (string.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
                {
                    errorProvider1.SetError(txtPhoneNumber, "Required");
                    isValid = false;
                    return;
                }
                if (!isValidPhone((txtPhoneNumber.Text.Trim())))
                {
                    errorProvider1.SetError(txtPhoneNumber, "Invalid phone number!");
                    isValid = false;
                    return;
                }
                if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
                {
                    errorProvider1.SetError(txtAddress, "Required");
                    isValid = false;
                    return;
                }
                if (isValid)
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
                    order.OrderId = "OD" + newOrderNumber;

                    if (UserInfo.UserId != null)
                    {
                        order.UserId = UserInfo.UserId;
                    }

                    List<OrderDetail> details = new List<OrderDetail>();

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
                        details.Add(orderDetail);
                        //order.OrderDetails.Add(orderDetail);
                        //_orderDetailService.CreateNewOrderDetail(orderDetail);
                    }
                    //order.OrderDetails = null;

                    _orderService.CreateNewOrder(order);

                    foreach (var detail in details)
                    {
                        _orderDetailService.CreateNewOrderDetail(detail);
                    }
                    Cart.CartDetails = new List<CartDetail>();
                    MessageBox.Show("Ordered Successfully! Please wait 2-3 days for the delivery.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            if (UserInfo.UserId != null)
            {
                txtAddress.Text = UserInfo.Address.ToString();
                txtPhoneNumber.Text = UserInfo.Phone.ToString();
                linkLogin.Visible = false;
            }
            else
            {
                linkLogin.Visible = true;
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerLoginForm customerLoginForm = new CustomerLoginForm();
            var result = customerLoginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Loged in Successfully!");
                linkLogin.Visible = false;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txtPhoneNumber.Text.Length > 9 && isValidPhone(txtPhoneNumber.Text.Trim()))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private bool isValidPhone(string phone)
        {
            string regex = @"^0\d{9}$";

            return Regex.IsMatch(phone, regex);
        }
    }
}
