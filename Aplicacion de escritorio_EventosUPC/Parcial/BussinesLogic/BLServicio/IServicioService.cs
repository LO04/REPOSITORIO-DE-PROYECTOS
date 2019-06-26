using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLServicio
{
    public interface IServicioService
    {
        List<Servicio> ObtenerServicios();
    }
}
