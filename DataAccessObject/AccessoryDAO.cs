using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccessObject;
public class AccessoryDAO
{
    private static AccessoryDAO instance;
    public AccessoryDAO() { }
    public static AccessoryDAO Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AccessoryDAO();
            }
            return instance;
        }
    }
    public List<Accessory> GetAccessories()
    {
        var dbContext = new BirdCageShopContext();
        return dbContext.Accessories.ToList();
    }
    public Accessory GetAccessoryById(string id)
    {
        var dbContext = new BirdCageShopContext();
        return dbContext.Accessories.SingleOrDefault(m => m.AccessoryId.Equals(id));
    }
}
