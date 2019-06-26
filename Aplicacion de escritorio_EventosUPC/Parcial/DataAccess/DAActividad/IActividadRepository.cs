using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAActividad
{
    public interface IActividadRepository
    {
        List<Actividad> ObtenerActividades();
    }
}
