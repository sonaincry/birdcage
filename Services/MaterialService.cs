using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Repositories;

namespace Services;
public class MaterialService : IMaterialService
{
    private readonly IMaterialRepository materialRepository;
    public MaterialService()
    {
        materialRepository = new MaterialRepository();
    }
    public List<Material> GetMaterials()
    {
        return materialRepository.GetMaterials();
    }
}
