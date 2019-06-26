using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLEquipo
{
    public interface IEquipoService
    {
        List<Equipo> ObtenerEquipos();
    }
}
