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
    public partial class CagesListForm : Form
    {
        private readonly IProductService productService;
        private string selectedCageName;
        private Product selectedCage = new Product();

        public Product ReturnProduct { get; set; }

        public CagesListForm()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        public CagesListForm(string name)
        {
            InitializeComponent();
            productService = new ProductService();
            this.selectedCageName = name;
        }

        private void CagesListForm_Load(object sender, EventArgs e)
        {
            dgvProduct.DataSource = productService.GetProducts().Select(c => new { c.ProductId, c.Name, c.Price, c.Description, c.Spoke }).Where(p => p.Name != this.selectedCageName).ToList();
            dgvProduct.Columns["ProductId"].Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var tempProduct = new Product
            {
                ProductId = dgvProduct.CurrentRow.Cells[0].Value.ToString(),
                Name = dgvProduct.CurrentRow.Cells[1].Value.ToString(),
                Price = double.Parse(dgvProduct.CurrentRow.Cells[2].Value.ToString()),
                Description = dgvProduct.CurrentRow.Cells[3].Value.ToString(),
                Spoke = int.Parse(dgvProduct.CurrentRow.Cells[4].Value.ToString()),
            };
            this.ReturnProduct = tempProduct;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
