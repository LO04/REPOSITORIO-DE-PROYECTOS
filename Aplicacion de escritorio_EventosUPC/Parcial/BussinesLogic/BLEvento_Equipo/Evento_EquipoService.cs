using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento_Equipo;

namespace BussinesLogic.BLEvento_Equipo
{
    public class Evento_EquipoService : IEvento_EquipoService
    {
        private IEvento_EquipoRepository repository;
        private IEvento_EquipoRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new Evento_EquipoRepository();
                }
                return repository;

            }

        }
        public void CrearEvento_Equipo(Evento_Equipo obj)
        {
            Myrepository.CrearEvento_Equipo(obj);
        }

        public void EliminarEvento_Equipos(int id)
        {
            Myrepository.EliminarEvento_Equipos(id);
        }

        public List<Evento_Equipo> ListarPorEquipo(int EquipoID)
        {
            return Myrepository.ListarPorEquipo(EquipoID);
        }

        public List<Evento_Equipo> ListarPorEvento(int EventoID)
        {
            return Myrepository.ListarPorEvento(EventoID);
        }

        public List<Evento_Equipo> ObtenerEvento_Equipos()
        {
            return Myrepository.ObtenerEvento_Equipos();
        }
    }
}
