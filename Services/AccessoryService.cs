using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Repositories;

namespace Services;
public class AccessoryService : IAccessoryService
{
    private readonly IAccessoryRepository accessoryRepository;
    public AccessoryService()
    {
        accessoryRepository = new AccessoryRepository();
    }
    public List<Accessory> GetAccessories()
    {
        return accessoryRepository.GetAccessories();
    }

    public Accessory GetAccessoryById(string id)
    {
        return accessoryRepository.GetAccessoryById(id);
    }
}
