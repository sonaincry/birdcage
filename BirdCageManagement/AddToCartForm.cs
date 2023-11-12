using BussinessObject;
using BussinessObject.Models;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AddToCartForm : Form
    {
        private Product addedCage;
        public AddToCartForm()
        {
            InitializeComponent();
        }

        public AddToCartForm(Product cage)
        {
            InitializeComponent();
            this.addedCage = cage;
        }

        private void AddToCartForm_Load(object sender, EventArgs e)
        {
            txtSelectedName.Text = this.addedCage.Name;
            txtSelectedPrice.Text = this.addedCage.Price.ToString();
            txtSelectedDescription.Text = this.addedCage.Description;
            txtSelectedSpoke.Text = this.addedCage.Spoke.ToString();
            txtQuantity.Text = "1";
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (!this.txtQuantity.Text.IsNullOrEmpty())
            {
                var quantity = int.Parse(this.txtQuantity.Text);
                if (quantity > 1)
                {
                    quantity -= 1;
                    this.txtQuantity.Text = quantity.ToString();
                }
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (!this.txtQuantity.Text.IsNullOrEmpty())
            {
                var quantity = int.Parse(this.txtQuantity.Text);
                quantity += 1;
                this.txtQuantity.Text = quantity.ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var cartDetail = new CartDetail();
            cartDetail.Product = new Product { 
                ProductId = addedCage.ProductId,
                Name = addedCage.Name,
                Description = addedCage.Description,
                Price = addedCage.Price,
                Accessories = addedCage.Accessories,
                Spoke = addedCage.Spoke,
                Materials = addedCage.Materials,
            };
            //cartDetail.Product = addedCage;
            cartDetail.Quantity = int.Parse(txtQuantity.Text);
            cartDetail.SumPrice = (double)(addedCage.Price * cartDetail.Quantity);

            var tempDetails = Cart.CartDetails;
            Cart.CartDetails.Add(cartDetail);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
