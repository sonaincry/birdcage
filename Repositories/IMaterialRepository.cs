﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Repositories;
public interface IMaterialRepository
{
    List<Material> GetMaterials();
    Material GetMaterialById(string id);
}
