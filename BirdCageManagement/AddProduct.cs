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

namespace BirdCageManagement;
public partial class AddProduct : Form
{
    private readonly IProductService productService;
    public AddProduct()
    {
        InitializeComponent();
        productService = new ProductService();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            bool isValid = true;
            Product product = new Product();
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "Required");
                isValid = false;
                return;
            }
            if (productService.IsNameExist(txtName.Text.Trim()))
            {
                errorProvider1.SetError(txtName, "This product already exist please select different name!");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                errorProvider1.SetError(txtPrice, "Required");
                isValid = false;
                return;
            }
            if (string.IsNullOrEmpty(txtSpoke.Text.Trim()))
            {
                errorProvider1.SetError(txtSpoke, "Required");
                isValid = false;
                return;
            }
            if (!IsValidPrice(int.Parse(txtPrice.Text.Trim())))
            {
                errorProvider1.SetError(txtPrice, "Price must at least 1000VND");
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
                product.Name = txtName.Text.Trim();
                product.Description = txtDescription.Text.Trim();
                product.Price = double.Parse(txtPrice.Text.Trim());
                product.Status = 1;
                product.Spoke = int.Parse(txtSpoke.Text.Trim());

                string maxProductId = productService.GetMaxProductId();

                int currentNumber = int.Parse(maxProductId.Substring(1));
                int newNumber = currentNumber + 1;

                // Create the new user ID by formatting it with leading zeros
                string newProductNumber = newNumber.ToString("D2");
                product.ProductId = "P" + newProductNumber;

                productService.AddProduct(product);
                MessageBox.Show("Add successfully");

                this.Hide();
                var bcm = new BirdCageManagement();
                bcm.Show();
            }
        }
        catch (FormatException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private bool IsValidSpoke(int number)
    {
        return number >= 51 && number <= 60;
    }
    private bool IsValidPrice(int number)
    {
        return number > 1000;
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        var bm = new BirdCageManagement();
        bm.Show();
    }
}



