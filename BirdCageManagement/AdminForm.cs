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
    public partial class AdminForm : Form
    {
        private readonly IProductService productService;
        private readonly IUserService userService;
        public AdminForm()
        {
            InitializeComponent();
            productService = new ProductService();
            userService = new UserService();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var lf = new LoginForm();
            lf.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var lf = new UserManagement();
            lf.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var lf = new BirdCageManagement();
            lf.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productService.GetProducts().Select(c => new { c.ProductId, c.Name, c.Price, c.Description, c.Status, c.Spoke }).ToList();
            dgvUser.DataSource = userService.GetUsers().Select(u => new { u.UserId, u.Fullname, u.Email, u.Address, u.Phone, u.Role, u.CreatedDate }).ToList();
        }
    }
}
