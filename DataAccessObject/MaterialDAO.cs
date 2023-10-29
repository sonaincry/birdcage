using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccessObject;
public class MaterialDAO
{
    private static MaterialDAO instance;
    public MaterialDAO() { }
    public static MaterialDAO Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new MaterialDAO();
            }
            return instance;
        }
    }
    public List<Material> GetMaterials()
    {
        var dbContext = new BirdCageShopContext();
        return dbContext.Materials.ToList();
    }
}
