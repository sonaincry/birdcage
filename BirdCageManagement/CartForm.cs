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
    public partial class CartForm : Form
    {
        private CartDetail currentCartDetail = new CartDetail();
        BindingSource source = new BindingSource();
        public CartForm()
        {
            InitializeComponent();
            currentCartDetail.Product = new Product();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            source.DataSource = Cart.CartDetails.Select(c => new { c.Product.ProductId, c.Product.Name, c.Product.Price, c.Quantity, c.SumPrice }).ToList();
            dgvCart.DataSource = source;
            dgvCart.Columns[0].Visible = false;
            dgvCart.Rows[0].Selected = true;

            currentCartDetail.Product.ProductId = dgvCart.Rows[0].Cells[0].Value.ToString();
            currentCartDetail.Product.Name = dgvCart.Rows[0].Cells["Name"].Value.ToString();
            currentCartDetail.Product.Price = double.Parse(dgvCart.Rows[0].Cells["Price"].Value.ToString());
            currentCartDetail.Quantity = int.Parse(dgvCart.Rows[0].Cells["Quantity"].Value.ToString());
            currentCartDetail.SumPrice = double.Parse(dgvCart.Rows[0].Cells["SumPrice"].Value.ToString());

            txtName.Text = currentCartDetail.Product.Name;
            txtPrice.Text = currentCartDetail.Product.Price.ToString();
            txtQuantity.Text = currentCartDetail.Quantity.ToString();
            txtSumPrice.Text = currentCartDetail.SumPrice.ToString();

            double total = 0;
            foreach (var detail in Cart.CartDetails)
            {
                total += detail.SumPrice;
            }
            txtTotal.Text = total.ToString();
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentCartDetail.Product.ProductId = dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString();
            currentCartDetail.Product.Name = dgvCart.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            currentCartDetail.Product.Price = double.Parse(dgvCart.Rows[e.RowIndex].Cells["Price"].Value.ToString());
            currentCartDetail.Quantity = int.Parse(dgvCart.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
            currentCartDetail.SumPrice = double.Parse(dgvCart.Rows[e.RowIndex].Cells["SumPrice"].Value.ToString());

            txtName.Text = currentCartDetail.Product.Name;
            txtPrice.Text = currentCartDetail.Product.Price.ToString();
            txtQuantity.Text = currentCartDetail.Quantity.ToString();
            txtSumPrice.Text = currentCartDetail.SumPrice.ToString();
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

                    currentCartDetail.Quantity = quantity;
                    currentCartDetail.SumPrice = (double)(quantity * currentCartDetail.Product.Price);
                    foreach (var detail in Cart.CartDetails.Where(d => d.Product.ProductId == currentCartDetail.Product.ProductId))
                    {
                        detail.Quantity = quantity;
                        detail.SumPrice = currentCartDetail.SumPrice;
                    }
                    this.txtSumPrice.Text = currentCartDetail.SumPrice.ToString();

                    double total = 0;
                    foreach (var detail in Cart.CartDetails)
                    {
                        total += detail.SumPrice;
                    }
                    txtTotal.Text = total.ToString();

                    source.DataSource = Cart.CartDetails.Select(c => new { c.Product.ProductId, c.Product.Name, c.Product.Price, c.Quantity, c.SumPrice }).ToList();
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

                currentCartDetail.Quantity = quantity;
                currentCartDetail.SumPrice = (double)(quantity * currentCartDetail.Product.Price);
                foreach (var detail in Cart.CartDetails.Where(d => d.Product.ProductId == currentCartDetail.Product.ProductId))
                {
                    detail.Quantity = quantity;
                    detail.SumPrice = currentCartDetail.SumPrice;
                }
                this.txtSumPrice.Text = currentCartDetail.SumPrice.ToString();

                double total = 0;
                foreach (var detail in Cart.CartDetails)
                {
                    total += detail.SumPrice;
                }
                txtTotal.Text = total.ToString();

                source.DataSource = Cart.CartDetails.Select(c => new { c.Product.ProductId, c.Product.Name, c.Product.Price, c.Quantity, c.SumPrice }).ToList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var deletedDetail = Cart.CartDetails.Single(d => d.Product.ProductId.Equals(currentCartDetail.Product.ProductId));
            if (deletedDetail != null)
            {
                Cart.CartDetails.Remove(deletedDetail);
            }
            source.DataSource = Cart.CartDetails.Select(c => new { c.Product.ProductId, c.Product.Name, c.Product.Price, c.Quantity, c.SumPrice }).ToList();

            if (Cart.CartDetails.Count > 0)
            {
                currentCartDetail.Product.ProductId = dgvCart.Rows[0].Cells[0].Value.ToString();
                currentCartDetail.Product.Name = dgvCart.Rows[0].Cells["Name"].Value.ToString();
                currentCartDetail.Product.Price = double.Parse(dgvCart.Rows[0].Cells["Price"].Value.ToString());
                currentCartDetail.Quantity = int.Parse(dgvCart.Rows[0].Cells["Quantity"].Value.ToString());
                currentCartDetail.SumPrice = double.Parse(dgvCart.Rows[0].Cells["SumPrice"].Value.ToString());

                double total = 0;
                foreach (var detail in Cart.CartDetails)
                {
                    total += detail.SumPrice;
                }
                txtTotal.Text = total.ToString();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            var result = checkoutForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
