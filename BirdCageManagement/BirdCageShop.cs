using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
using BussinessObject.Models;
using Microsoft.IdentityModel.Tokens;
using Services;
using static System.Reflection.Metadata.BlobBuilder;

namespace BirdCageManagement;
public partial class BirdCageShop : Form
{
    private readonly IProductService productService;
    private Product currentCage = new Product();
    public BirdCageShop()
    {
        InitializeComponent();
        Cart.CartDetails = new List<CartDetail>();

        productService = new ProductService();
    }

    private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        currentCage.ProductId = dgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
        currentCage.Name = dgvProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        currentCage.Price = double.Parse(dgvProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString());
        currentCage.Description = dgvProduct.Rows[e.RowIndex].Cells["Description"].Value.ToString();
        currentCage.Spoke = int.Parse(dgvProduct.Rows[e.RowIndex].Cells["Spoke"].Value.ToString());

        txtName.Text = currentCage.Name;
        txtPrice.Text = currentCage.Price.ToString();
        txtDescription.Text = currentCage.Description;
        txtSpoke.Text = currentCage.Spoke.ToString();
    }

    private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void BirdCageShop_Load(object sender, EventArgs e)
    {
        if (UserInfo.UserId != null)
        {
            btnHistory.Visible = true;
            lblWelcome.Text = "Welcome " + UserInfo.Fullname;
            lblWelcome.Visible = true;
            btnLogin.Text = "Logout";
        }
        else
        {
            btnHistory.Visible = false;
            lblWelcome.Text = "";
            lblWelcome.Visible = false;
            btnLogin.Text = "Customer Login";
        }
        dgvProduct.DataSource = productService.GetProducts().Select(c => new { c.ProductId, c.Name, c.Price, c.Description, c.Spoke }).ToList();
        dgvProduct.Columns["ProductId"].Visible = false;
        dgvProduct.Rows[0].Selected = true;
        currentCage.ProductId = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
        currentCage.Name = dgvProduct.SelectedRows[0].Cells["Name"].Value.ToString();
        currentCage.Price = double.Parse(dgvProduct.SelectedRows[0].Cells["Price"].Value.ToString());
        currentCage.Description = dgvProduct.Rows[0].Cells["Description"].Value.ToString();
        currentCage.Spoke = int.Parse(dgvProduct.Rows[0].Cells["Spoke"].Value.ToString());

        txtName.Text = currentCage.Name;
        txtPrice.Text = currentCage.Price.ToString();
        txtDescription.Text = currentCage.Description;
        txtSpoke.Text = currentCage.Spoke.ToString();
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {
        CompareForm compareForm = new CompareForm(currentCage);
        compareForm.ShowDialog();
    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void btnPurchase_Click(object sender, EventArgs e)
    {
        AddToCartForm addToCart = new AddToCartForm(currentCage);
        addToCart.ShowDialog();
    }

    private void btnCart_Click(object sender, EventArgs e)
    {
        if (Cart.CartDetails.Count > 0 || !Cart.CartDetails.IsNullOrEmpty())
        {
            CartForm cartForm = new CartForm();
            cartForm.ShowDialog();
        }
        else
        {
            MessageBox.Show("You don't have anything in Cart yet!");
        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        if(UserInfo.UserId.IsNullOrEmpty())
        {
            CustomerLoginForm customerLoginForm = new CustomerLoginForm();
            var result = customerLoginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Loged in Successfully!");
                btnHistory.Visible = true;
                lblWelcome.Text = "Welcome " + UserInfo.Fullname;
                lblWelcome.Visible = true;
                btnLogin.Text = "Logout";
            }
        } else
        {
            var confirmResult = MessageBox.Show(
                "Are you sure to Logout?",
                "Loged out",
                MessageBoxButtons.YesNo
                );
            if (confirmResult == DialogResult.Yes)
            {
                UserInfo.UserId = null;
                UserInfo.Email = null;
                UserInfo.Password = null;
                UserInfo.Fullname = null;
                UserInfo.Role = null;
                UserInfo.Phone = null;
                UserInfo.Address = null;
                UserInfo.CreatedDate = null;

                lblWelcome.Text = "";
                lblWelcome.Visible = false;
                btnLogin.Text = "Customer Login";
                btnHistory.Visible = false;
            }
        }
    }

    private void btnHistory_Click(object sender, EventArgs e)
    {
        OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
        orderHistoryForm.ShowDialog();
    }
}
