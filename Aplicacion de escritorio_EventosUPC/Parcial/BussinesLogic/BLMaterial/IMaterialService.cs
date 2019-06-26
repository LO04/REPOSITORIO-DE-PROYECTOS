using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLMaterial
{
    public interface IMaterialService
    {
        List<Material> ObtenerMateriales();
    }
}
