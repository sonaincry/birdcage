﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessObject;
public class ProductDAO
{
    private static ProductDAO instance = null;

    public ProductDAO() { }
    public static ProductDAO Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ProductDAO();
            }
            return instance;
        }
    }
    public List<Product> GetProducts()
    {
        var dbContext = new BirdCageShopContext();
        return dbContext.Products.ToList();
    }
    public Product GetProductById(string id)
    {
        var dbContext = new BirdCageShopContext();
        return dbContext.Products.SingleOrDefault(m => m.ProductId.Equals(id));
    }
    public void AddProduct(Product product)
    {
        try
        {
            var dbContext = new BirdCageShopContext();
            Product p = GetProductById(product.ProductId);
            if (p == null)
            {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Id has existed!");
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void UpdateProduct(Product product)
    {
        try
        {
            var dbContext = new BirdCageShopContext();
            if (product != null)
            {
                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Nothing to update!");
            }


        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void DeleteProduct(Product product)
    {
        try
        {
            var dbContext = new BirdCageShopContext();
            if (product != null)
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }   
    }
    
    public string GetMaxProductId()
    {
        try
        {
            using (var dbContext = new BirdCageShopContext())
            {
                var maxProductId = dbContext.Products
                    .Where(p => p.ProductId.StartsWith("P"))
                    .OrderByDescending(p => p.ProductId)
                    .Select(p => p.ProductId)
                    .FirstOrDefault();

                return maxProductId;
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error while retrieving max user ID: " + ex.Message);
        }
    }
    public void UpdatePrice(Product product, double? price)
    {
        try
        {
            var dbContext = new BirdCageShopContext();
            if (product != null)
            {
                product.ProductId = product.ProductId;
                product.Name = product.Name;
                product.Spoke = product.Spoke;
                product.Price = price;
                product.Description = product.Description;
                product.Status = product.Status;
                dbContext.Update(product);
                dbContext.SaveChanges();
            }
            
        }
        catch (Exception ex)
        {
            throw new Exception("Error while retrieving max user ID: " + ex.Message);
        }
    }
    public bool IsNameExist(string name)
    {
        using (var dbContext = new BirdCageShopContext())
        {
            bool existEmail = dbContext.Products.Any(u => u.Name == name);
            return existEmail;
        }
    }
    public void SoftDeleteProduct(string productId)
    {
        try
        {
            var dbContext = new BirdCageShopContext();
            var product = dbContext.Products.SingleOrDefault(m => m.ProductId.Equals(productId));

            if (product != null)
            {
                // Soft delete by changing the status
                product.Status = (product.Status == 1) ? 0 : 1;
                dbContext.SaveChanges();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error while soft deleting product: " + ex.Message);
        }
    }
}
