using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEquipo
{
    public class EquipoRepository : IEquipoRepository
    {
        public List<Equipo> ObtenerEquipos()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Equipo
                            select io;
                List<Equipo> equipos= query.ToList();
                return equipos;
            }
        }
    }
}
