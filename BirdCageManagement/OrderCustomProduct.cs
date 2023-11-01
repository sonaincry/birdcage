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
using DataAccessObject;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Services;

namespace BirdCageManagement;
public partial class OrderCustomProduct : Form
{
    private readonly IMaterialService materialService;
    private readonly IAccessoryService accessoryService;
    private readonly IProductService productService;
    public OrderCustomProduct()
    {
        InitializeComponent();
        materialService = new MaterialService();
        accessoryService = new AccessoryService();
        productService = new ProductService();
    }

    private void OrderCustomProduct_Load(object sender, EventArgs e)
    {
        clMaterial.DataSource = materialService.GetMaterials();
        clMaterial.DisplayMember = "Name";
        clAccessories.DataSource = accessoryService.GetAccessories();
        clAccessories.DisplayMember = "Name";
    }

    private void btnOrder_Click(object sender, EventArgs e)
    {
        Product product = new Product();
        product.Status = 0;
        product.Spoke = int.Parse(txtSpoke.Text.Trim());
        product.Price = 0;
        product.Description = "";
        product.Name = txtName.Text.Trim();

        string maxProductId = productService.GetMaxProductId();

        int currentNumber = int.Parse(maxProductId.Substring(1));
        int newNumber = currentNumber + 1;

        string newProductNumber = newNumber.ToString("D2");
        product.ProductId = "P" + newProductNumber;

        productService.AddProduct(product);

        foreach (Material selectedMaterial in clMaterial.CheckedItems)
        {
            var dbContext = new BirdCageShopContext();
            dbContext.Database.ExecuteSqlRaw(
                "INSERT INTO ProductMaterial (ProductID, MaterialID) VALUES (@ProductID, @MaterialID)",
                new SqlParameter("ProductID", product.ProductId),
                new SqlParameter("MaterialID", selectedMaterial.MaterialId)
            );
        }

        MessageBox.Show("Order Successfully");

    }

    private void linklabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var bs = new BirdCageShop();
        bs.Show();
        this.Hide();
    }

    private void clMaterial_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
