using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAPersonal;

namespace BussinesLogic.BLPersonal
{
    public class PersonalService : IPersonalService
    {
        private IPersonalRepository repository;
        private IPersonalRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new PersonalRepository();
                }
                return repository;

            }

        }
        public void ActualizarPersonal(Personal obj)
        {
            Myrepository.ActualizarPersonal(obj);
        }

        public void CrearPersonal(Personal obj)
        {
            Myrepository.CrearPersonal(obj);
        }

        public void EliminarPersonal(int id)
        {
            Myrepository.EliminarPersonal(id);
        }

      

        public List<Personal> NombreAscendente()
        {
            return Myrepository.NombreAscendente();
        }

        public List<Personal> NombreDescendente()
        {
            return Myrepository.NombreDescendente();
        }

        public List<Personal> ObtenerPersonales()
        {
            return Myrepository.ObtenerPersonales();
        }
    }
}
