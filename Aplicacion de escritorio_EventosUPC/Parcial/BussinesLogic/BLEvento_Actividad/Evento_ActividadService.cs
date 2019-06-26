using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento_Actividad;

namespace BussinesLogic.BLEvento_Actividad
{
    public class Evento_ActividadService : IEvento_ActividadService
    {
        private IEvento_ActividadRepository repository;
        private IEvento_ActividadRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new Evento_ActividadRepository();
                }

                return repository;

            }

        }
        public void CrearEvento_Actividad(Evento_Actividad obj)
        {
            Myrepository.CrearEvento_Actividad(obj);
        }

        public void EliminarEvento_Actividades(int id)
        {
            Myrepository.EliminarEvento_Actividades(id);
        }

        public List<Evento_Actividad> listarPorActividad(int ActividadID)
        {
            return Myrepository.listarPorActividad(ActividadID);
        }

        public List<Evento_Actividad> listarPorEvento(int EventoID)
        {
            return Myrepository.listarPorEvento(EventoID);
        }

        public List<Evento_Actividad> ObtenerEvento_Actividades()
        {
            return Myrepository.ObtenerEvento_Actividades();
        }
    }
}
