using BussinessObject;
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
    public partial class OrderHistoryForm : Form
    {
        private readonly IOrderService _orderService;
        private BindingSource source;
        public OrderHistoryForm()
        {
            _orderService = new OrderService();
            source = new BindingSource();
            InitializeComponent();
        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            source.DataSource = _orderService.GetOrderByUserIdOrPhone(UserInfo.UserId, UserInfo.Phone)
                .Select(o => new { o.OrderId, o.Total, o.Phone, o.Address }).ToList();
            dgvOrders.DataSource = source;
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
