using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAMaterial
{
    public class MaterialRepository : IMaterialRepository
    {
        public List<Material> ObtenerMateriales()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Material
                            select io;
                List<Material> materiales = query.ToList();
                return materiales;
            }
        }
    }
}
