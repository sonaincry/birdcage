using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject.Models;
using Services;

namespace BirdCageManagement;
public partial class BirdCageShop : Form
{
    private readonly IProductService productService;
    public BirdCageShop()
    {
        InitializeComponent();
        productService = new ProductService();
    }

    private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        txtName.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
        txtPrice.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
        txtDescription.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
        txtSpoke.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();

    }

    private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void BirdCageShop_Load(object sender, EventArgs e)
    {
        dgvProduct.DataSource = productService.GetProducts().Select(c => new { c.Name, c.Price, c.Description, c.Spoke }).ToList();
    }

    private void btnCompare_Click(object sender, EventArgs e)
    {


    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
         
    }
}
