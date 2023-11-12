using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessObject;
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
    private readonly IOrderService orderService;
    private readonly IOrderDetailService orderDetailService;
    double? totalMaterialPrice = 0;
    double? totalAccessoryPrice = 0;
    double? totalSpokePrice = 0;
    List<Material> selectedMaterials = new List<Material>();
    List<Accessory> selectedAccessories = new List<Accessory>();
    public OrderCustomProduct()
    {
        InitializeComponent();
        materialService = new MaterialService();
        accessoryService = new AccessoryService();
        productService = new ProductService();
        orderService = new OrderService();
        orderDetailService = new OrderDetailService();
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
        try
        {
            if (clMaterial.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please choose at least 1 material!");
                return;
            }
            if (clMaterial.CheckedItems.Count > 3)
            {
                MessageBox.Show("Just maximium 3 materials, please remove some!");
                return;
            }
            else
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
                    selectedMaterials.Add(selectedMaterial);
                }
                foreach (Accessory selectedAccessory in clAccessories.CheckedItems)
                {
                    var dbContext = new BirdCageShopContext();
                    dbContext.Database.ExecuteSqlRaw(
                        "INSERT INTO ProductAccessory (ProductID, AccessoryID) VALUES (@ProductID, @AccessoryID)",
                        new SqlParameter("ProductID", product.ProductId),
                        new SqlParameter("AccessoryID", selectedAccessory.AccessoryId)
                    );
                    selectedAccessories.Add(selectedAccessory);

                }
                double? totalPrice = 0;
                foreach (Material material in selectedMaterials)
                {
                    string materialId = material.MaterialId;
                    double? mt = materialService.GetMaterialById(materialId).Price;
                    totalMaterialPrice += mt;
                }
                foreach (Accessory accessory in selectedAccessories)
                {
                    string accessoryId = accessory.AccessoryId;
                    double? ac = accessoryService.GetAccessoryById(accessoryId).Price;
                    totalAccessoryPrice += ac;
                }
                totalSpokePrice = product.Spoke * 48000;
                totalPrice = totalMaterialPrice + totalAccessoryPrice + totalSpokePrice;

                productService.UpdatePrice(product, totalPrice);

                //Save Order
                string maxOrderId = orderService.GetMaxOrderId();
                int currentOrderNumber = int.Parse(maxOrderId.Substring(2));
                int newOrderNumber = currentNumber + 1;
                string orderNumber = newOrderNumber.ToString("D2");

                Order order = new Order();
                order.Total = totalPrice;
                order.Phone = UserInfo.Phone;
                order.Address = UserInfo.Address;
                order.CreatedDate = DateTime.Now;
                order.Status = 0;
                order.OrderId = "OD" + orderNumber;

                if (UserInfo.UserId != null)
                {
                    order.UserId = UserInfo.UserId;
                }

                string maxOrderDetailId = orderDetailService.GetMaxOrderDetailId();
                int cNumber = int.Parse(maxOrderDetailId.Substring(3));
                int newDTNumber = cNumber + 1;
                string newOrderDetailNumber = newDTNumber.ToString("D2");
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderDetailId = "ODT" + newOrderDetailNumber,
                    ProductId = product.ProductId,
                    OrderId = order.OrderId,
                    Quantity = 1,
                    Price = (int?)product.Price,
                };

                orderService.CreateNewOrder(order);

                orderDetailService.CreateNewOrderDetail(orderDetail);

                Int32 totalDay;
                if (selectedAccessories.Count == 0)
                {
                    if (selectedMaterials.Count == 1)
                    {
                        totalDay = 7;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                    if (selectedMaterials.Count == 2)
                    {
                        totalDay = 9;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                    if (selectedMaterials.Count == 3)
                    {
                        totalDay = 10;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                }
                else
                {
                    if (selectedMaterials.Count == 1)
                    {
                        totalDay = 8;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                    if (selectedMaterials.Count == 2)
                    {
                        totalDay = 10;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                    if (selectedMaterials.Count == 3)
                    {
                        totalDay = 11;
                        DateTime expectedDate = DateTime.Now.AddDays(totalDay);
                        string showDate = expectedDate.ToString("dd-MM-yyyy");
                        MessageBox.Show("Order Successfully, Your price is: " + totalPrice + " and expected date is: " + showDate);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

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
