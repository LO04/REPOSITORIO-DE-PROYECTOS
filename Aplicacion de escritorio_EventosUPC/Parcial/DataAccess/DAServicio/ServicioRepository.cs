using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAServicio
{
    public class ServicioRepository : IServicioRepository
    {
        public List<Servicio> ObtenerServicios()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Servicio
                            select io;
                List<Servicio> servicios = query.ToList();
                return servicios;
            }
        }
    }
}
