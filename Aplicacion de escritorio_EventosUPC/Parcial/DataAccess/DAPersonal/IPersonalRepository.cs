using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAPersonal
{
    public interface IPersonalRepository
    {
        void CrearPersonal(Personal obj);
        List<Personal> ObtenerPersonales();
        void EliminarPersonal(int id);
        void ActualizarPersonal(Personal obj);
        List<Personal> NombreAscendente();
        List<Personal> NombreDescendente();
    }
}
