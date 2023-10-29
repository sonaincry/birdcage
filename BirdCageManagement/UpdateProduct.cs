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

namespace BirdCageManagement
{
    public partial class UpdateProduct : Form
    {
        private readonly IProductService productService;
        public UpdateProduct()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = productService.GetProductById(txtProductId.Text.Trim());
            if (product != null)
            {
                product.Name = txtName.Text.Trim();
                product.Description = txtDescription.Text.Trim();
                product.Price = double.Parse(txtPrice.Text.Trim());
                product.Status = int.Parse(txtStatus.Text.Trim());
                product.Spoke = int.Parse(txtSpoke.Text.Trim());

                productService.UpdateProduct(product);

                MessageBox.Show("Update product successfully");

                this.Hide();
                var bcm = new BirdCageManagement();
                bcm.Show();

            }
            else
            {
                MessageBox.Show("Nothing to update");
            }
        }
    }
}
