using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento_Servicio;

namespace BussinesLogic.BLEvento_Servicio
{
    public class Evento_ServicioService : IEvento_ServicioService
    {
        private IEvento_ServicioRepository repository;
        private IEvento_ServicioRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new Evento_ServicioRepository();
                }
                return repository;

            }

        }
        public void CrearEvento_Servicio(Evento_Servicio obj)
        {
            Myrepository.CrearEvento_Servicio(obj);
        }

        public void EliminarEvento_Servicios(int id)
        {
            Myrepository.EliminarEvento_Servicios(id);
        }

        public List<Evento_Servicio> ListarPorEvento(int EventoID)
        {
            return Myrepository.ListarPorEvento(EventoID);
        }

        public List<Evento_Servicio> ListarPorServicio(int ServicioID)
        {
            return Myrepository.ListarPorServicio(ServicioID);
        }

        public List<Evento_Servicio> ObtenerEvento_Servicios()
        {
            return Myrepository.ObtenerEvento_Servicios();
        }
    }
}
