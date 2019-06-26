using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEvento_Actividad
{
    public class Evento_ActividadRepository : IEvento_ActividadRepository
    {
        public void CrearEvento_Actividad(Evento_Actividad obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Evento_Actividad.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarEvento_Actividades(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Actividad
                            where io.id_evento_actividad == id
                            select io;
                Evento_Actividad obj = query.FirstOrDefault();

                dataContext.Evento_Actividad.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Evento_Actividad> listarPorActividad(int ActividadID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Actividad.Include("Evento").Include("Actividad")
                            where io.id_actividad == ActividadID
                            select io;
                List<Evento_Actividad> evento_actividades = query.ToList();
                return evento_actividades;
            }
        }

        public List<Evento_Actividad> listarPorEvento(int EventoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Actividad.Include("Evento").Include("Actividad")
                            where io.id_evento == EventoID
                            select io;
                List<Evento_Actividad> evento_actividades = query.ToList();
                return evento_actividades;
            }
        }
        public List<Evento_Actividad> ObtenerEvento_Actividades()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Actividad.Include("Evento").Include("Actividad")
                            select io;
                List<Evento_Actividad> evento_actividades = query.ToList();
                return evento_actividades;
            }
        }
    }
}
