using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccessObject;

namespace Repositories;
public class MaterialRepository : IMaterialRepository
{
    public List<Material> GetMaterials()=>MaterialDAO.Instance.GetMaterials();
}
