﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            dgvProduct.DataSource = productService.GetProducts().Select(c => new { c.ProductId, c.Name, c.Price, c.Description, c.Status, c.Spoke }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*try
            {
                Product product = new Product();
                *//*product.ProductId = txtProductId.Text.Trim();*//*
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
            }*/
            var ap = new AddProduct();
            ap.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Product product = productService.GetProductById(txtProductId.Text.Trim());
            if (product != null)
            {
                bool isValid = true;
                if (string.IsNullOrEmpty(txtProductName.Text.Trim()))
                {
                    errorProvider1.SetError(txtProductName, "Required");
                    isValid = false;
                    return;
                }
                if (productService.IsNameExist(txtProductName.Text.Trim()))
                {
                    errorProvider1.SetError(txtProductName, "This product already exist please select different name!");
                    isValid = false;
                    return;
                }
                if (string.IsNullOrEmpty(txtProductPrice.Text.Trim()))
                {
                    errorProvider1.SetError(txtProductPrice, "Required");
                    isValid = false;
                    return;
                }
                if (string.IsNullOrEmpty(txtSpoke.Text.Trim()))
                {
                    errorProvider1.SetError(txtSpoke, "Required");
                    isValid = false;
                    return;
                }
                if (!IsValidPrice(int.Parse(txtProductPrice.Text.Trim())))
                {
                    errorProvider1.SetError(txtProductPrice, "Price must at least 1000VND");
                    isValid = false;
                    return;
                }
                if (!IsValidSpoke(int.Parse(txtSpoke.Text.Trim())))
                {
                    errorProvider1.SetError(txtSpoke, "Spoke must at least 51 and maxium 60");
                    isValid = false;
                    return;
                }
                if (isValid)
                {
                    product.Name = txtProductName.Text.Trim();
                    product.Description = txtDescription.Text.Trim();
                    product.Price = double.Parse(txtProductPrice.Text.Trim());
                    product.Status = 1;
                    product.Spoke = int.Parse(txtSpoke.Text.Trim());

                    productService.UpdateProduct(product);

                    MessageBox.Show("Update product successfully");

                    dgvProduct.DataSource = productService.GetProducts();
                }
            }
            else
            {
                MessageBox.Show("Nothing to update");
            }
            /*var up = new UpdateProduct();
            up.Show();
            this.Hide();*/
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
                productService.SoftDeleteProduct(product.ProductId);

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
            /*txtStatus.Enabled = false;*/
            txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtProductPrice.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtDescription.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtStatus.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtSpoke.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var lg = new LoginForm();
            lg.Show();
        }
        private bool IsValidSpoke(int number)
        {
            return number >= 51 && number <= 60;
        }
        private bool IsValidPrice(int number)
        {
            return number > 1000;
        }
    }
}
