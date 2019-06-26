using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAEquipo
{
    public interface IEquipoRepository
    {
        List<Equipo> ObtenerEquipos();
    }
}
