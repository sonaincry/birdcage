﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace Services;
public interface IMaterialService
{
    List<Material> GetMaterials();
    Material GetMaterialById(string id);
}
