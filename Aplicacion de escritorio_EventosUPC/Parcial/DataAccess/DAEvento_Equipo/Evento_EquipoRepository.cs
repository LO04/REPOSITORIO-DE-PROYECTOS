using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEvento_Equipo
{
    public class Evento_EquipoRepository : IEvento_EquipoRepository
    {
        public void CrearEvento_Equipo(Evento_Equipo obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Evento_Equipo.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarEvento_Equipos(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Equipo
                            where io.id_evento_equipo == id
                            select io;
                Evento_Equipo obj = query.FirstOrDefault();

                dataContext.Evento_Equipo.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Evento_Equipo> ListarPorEquipo(int EquipoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Equipo.Include("Evento").Include("Equipo")
                            where io.id_equipo==EquipoID
                            select io;
                List<Evento_Equipo> evento_equipos = query.ToList();
                return evento_equipos;
            }
        }

        public List<Evento_Equipo> ListarPorEvento(int EventoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Equipo.Include("Evento").Include("Equipo")
                            where io.id_evento==EventoID
                            select io;
                List<Evento_Equipo> evento_equipos = query.ToList();
                return evento_equipos;
            }
        }

        public List<Evento_Equipo> ObtenerEvento_Equipos()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Equipo.Include("Evento").Include("Equipo")
                            select io;
                List<Evento_Equipo> evento_equipos = query.ToList();
                return evento_equipos;
            }
        }
    }
}
