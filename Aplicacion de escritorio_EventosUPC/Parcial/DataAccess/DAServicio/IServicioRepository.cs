using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAServicio
{
    public interface IServicioRepository
    {
        List<Servicio> ObtenerServicios();
    }
}
