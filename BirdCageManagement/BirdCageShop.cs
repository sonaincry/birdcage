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
using Services;

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
        CartForm cartForm = new CartForm();
        cartForm.ShowDialog();
    }
}
