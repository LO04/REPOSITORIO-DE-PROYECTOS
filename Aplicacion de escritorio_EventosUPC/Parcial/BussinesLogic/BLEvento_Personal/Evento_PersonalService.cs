using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento_Personal;

namespace BussinesLogic.BLEvento_Personal
{
    public class Evento_PersonalService : IEvento_PersonalService
    {
        private IEvento_PersonalRepository repository;
        private IEvento_PersonalRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new Evento_PersonalRepository();
                }
                return repository;

            }

        }
        public void CrearEvento_Personal(Evento_Personal obj)
        {
            Myrepository.CrearEvento_Personal(obj);
        }

        public void EliminarEvento_Personales(int id)
        {
            Myrepository.EliminarEvento_Personales(id);
        }

        public List<Evento_Personal> ListarPorEvento(int EventoID)
        {
            return Myrepository.ListarPorEvento(EventoID);
        }

        public List<Evento_Personal> ListarPorPersonal(int PersonalID)
        {
            return Myrepository.ListarPorPersonal(PersonalID);
        }

        public List<Evento_Personal> ObtenerEvento_Personales()
        {
            return Myrepository.ObtenerEvento_Personales();
        }
    }
}
