using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Repositories;
public interface IProductRepository 
{
    List<Product> GetProducts();
    Product GetProductById(string id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    string GetMaxProductId();
    void UpdatePrice(Product product, double? price);
    bool IsNameExist(string name);
}
