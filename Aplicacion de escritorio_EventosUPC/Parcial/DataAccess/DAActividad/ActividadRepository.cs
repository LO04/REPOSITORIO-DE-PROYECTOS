using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAActividad
{
    public class ActividadRepository : IActividadRepository
    {
        public List<Actividad> ObtenerActividades()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Actividad
                            select io;
                List<Actividad> actividades = query.ToList();
                return actividades;
            }
        }
    }
}
