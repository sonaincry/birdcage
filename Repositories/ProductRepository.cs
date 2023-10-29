using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessObject;

namespace Repositories;
public class ProductRepository : IProductRepository
{

    public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

    public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);

    public string GetMaxProductId()=>ProductDAO.Instance.GetMaxProductId();

    public Product GetProductById(string id) => ProductDAO.Instance.GetProductById(id);

    public List<Product> GetProducts()=>ProductDAO.Instance.GetProducts();

    public void UpdatePrice(Product product, double? price)=>ProductDAO.Instance.UpdatePrice(product, price);

    public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
}
