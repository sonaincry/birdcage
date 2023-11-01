using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BirdCageManagement
{
    public partial class CompareForm : Form
    {
        private Product selectedCage;
        private Product comparedCage;
        public CompareForm()
        {
            InitializeComponent();
        }

        public CompareForm(Product cage)
        {
            this.selectedCage = cage;
            InitializeComponent();
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            txtSelectedName.Text = this.selectedCage.Name;
            txtSelectedPrice.Text = this.selectedCage.Price.ToString();
            txtSelectedDescription.Text = this.selectedCage.Description;
            txtSelectedSpoke.Text = this.selectedCage.Spoke.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CagesListForm cages = new CagesListForm(this.selectedCage.Name);
            var result = cages.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.comparedCage = cages.ReturnProduct;
                txtComparedName.Text = comparedCage.Name;
                txtComparedPrice.Text = comparedCage.Price.ToString();
                txtComparedDescription.Text = comparedCage.Description;
                txtComparedSpoke.Text = comparedCage.Spoke.ToString();
                btnPurchaseCompared.Enabled = true;
            }
        }

        private void btnPurchaseSelected_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCart = new AddToCartForm(this.selectedCage);
            addToCart.ShowDialog();
        }

        private void btnPurchaseCompared_Click(object sender, EventArgs e)
        {
            if (this.comparedCage != null)
            {
                AddToCartForm addToCart = new AddToCartForm(this.comparedCage);
                addToCart.ShowDialog();
            }
        }
    }
}
