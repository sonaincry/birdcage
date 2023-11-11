using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessObject;

namespace Repositories;
public class AccessoryRepository : IAccessoryRepository
{
    public List<Accessory> GetAccessories()=>AccessoryDAO.Instance.GetAccessories();

    public Accessory GetAccessoryById(string id)=>AccessoryDAO.Instance.GetAccessoryById(id);
}
