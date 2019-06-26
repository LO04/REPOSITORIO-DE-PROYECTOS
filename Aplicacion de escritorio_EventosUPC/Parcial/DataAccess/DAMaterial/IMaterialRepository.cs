using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAMaterial
{
    public interface IMaterialRepository
    {
        List<Material> ObtenerMateriales();
    }
}
