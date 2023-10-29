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
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Services;

namespace BirdCageManagement
{
    public partial class BirdCageManagement : Form
    {
        private readonly IProductService productService;
        public BirdCageManagement()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BirdCageManagement_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productService.GetProducts().Select(c => new {c.ProductId, c.Name, c.Price, c.Description, c.Status, c.Spoke}).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                /*product.ProductId = txtProductId.Text.Trim();*/
                product.Name = txtProductName.Text.Trim();
                product.Description = txtDescription.Text.Trim();
                product.Price = double.Parse(txtProductPrice.Text.Trim());
                product.Status = 1;
                product.Spoke = int.Parse(txtSpoke.Text.Trim());

                string maxProductId = productService.GetMaxProductId();

                int currentNumber = int.Parse(maxProductId.Substring(1)); // Assumes "userXX" format
                int newNumber = currentNumber + 1;

                // Create the new user ID by formatting it with leading zeros
                string newProductNumber = newNumber.ToString("D2"); // "D2" format ensures it's two digits
                product.ProductId = "P" + newProductNumber;

                productService.AddProduct(product);
                MessageBox.Show("Add successfully");
                dgvProduct.DataSource = productService.GetProducts();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = productService.GetProductById(txtProductId.Text.Trim());
            if (product != null)
            {
                product.Name = txtProductName.Text.Trim();
                product.Description = txtDescription.Text.Trim();
                product.Price = double.Parse(txtProductPrice.Text.Trim());
                product.Status = int.Parse(txtStatus.Text.Trim());
                product.Spoke = int.Parse(txtSpoke.Text.Trim());

                productService.UpdateProduct(product);

                MessageBox.Show("Update product successfully");

                dgvProduct.DataSource = productService.GetProducts();

            }
            else
            {
                MessageBox.Show("Nothing to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*Product product = productService.GetProductById(txtProductId.Text.Trim());
            if (product != null)
            {
                productService.DeleteProduct(product);

                MessageBox.Show("Delete product successfully");

                dgvProduct.DataSource = productService.GetProducts();
            }
            else
            {
                MessageBox.Show("Nothing to delete");
            }*/
            Product product = productService.GetProductById(txtProductId.Text.Trim());
            if (product != null)
            {
                product.Name = txtProductName.Text.Trim();
                product.Description = txtDescription.Text.Trim();
                product.Price = double.Parse(txtProductPrice.Text.Trim());
                product.Status = 0;
                product.Spoke = int.Parse(txtSpoke.Text.Trim());

                productService.UpdateProduct(product);

                MessageBox.Show("Delete product successfully");

                dgvProduct.DataSource = productService.GetProducts();

            }
            else
            {
                MessageBox.Show("Nothing to Delete");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.Trim();
            dgvProduct.DataSource = productService.GetProducts().Where(p => p.Name.Contains(keyword)).ToList();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductId.Enabled = false;
            txtStatus.Enabled = false;
            txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtProductPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtStatus.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtSpoke.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
