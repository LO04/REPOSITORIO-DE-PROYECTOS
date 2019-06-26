using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DALocal;

namespace BussinesLogic.BLLocal
{
    public class LocalService : ILocalService
    {
        private ILocalRepository repository;
        private ILocalRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new LocalRepository();
                }
                return repository;

            }
        }
        public void ActualizarLocal(Local objLocal)
        {
            Myrepository.ActualizarLocal(objLocal);
        }

        public void EliminarLocal(int LocalID)
        {
            Myrepository.EliminarLocal(LocalID);
        }

        public List<Local> ListarLocales()
        {
            return Myrepository.ListarLocales();
        }

        public List<Local> NombreAscendente()
        {
            return Myrepository.NombreAscendente();
        }

        public List<Local> NombreDescendente()
        {
            return Myrepository.NombreDescendente();
        }

        public void RegistrarLocal(Local objLocal)
        {
            Myrepository.RegistrarLocal(objLocal);
        }
    }
}
