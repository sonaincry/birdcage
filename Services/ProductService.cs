using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Repositories;

namespace Services;
public class ProductService : IProductService
{
    private readonly IProductRepository productRepository;
    public ProductService()
    {
        productRepository = new ProductRepository();
    }

    public void AddProduct(Product product)
    {
        productRepository.AddProduct(product);
    }

    public void DeleteProduct(Product product)
    {
        productRepository.DeleteProduct(product);
    }

    public string GetMaxProductId()
    {
        return productRepository.GetMaxProductId();
    }

    public Product GetProductById(string id)
    {
        return productRepository.GetProductById(id);
    }

    public List<Product> GetProducts()
    {
        return productRepository.GetProducts();
    }

    public void UpdateProduct(Product product)
    {
        productRepository.UpdateProduct(product);
    }
}
