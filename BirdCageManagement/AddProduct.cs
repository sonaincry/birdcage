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
            Product product = new Product();
            /*product.ProductId = txtProductId.Text.Trim();*/
            product.Name = txtName.Text.Trim();
            product.Description = txtDescription.Text.Trim();
            product.Price = double.Parse(txtPrice.Text.Trim());
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

            this.Hide();
            var bcm = new BirdCageManagement();
            bcm.Show();
        }
        catch (FormatException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}



