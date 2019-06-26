using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEvento_Servicio
{
    public class Evento_ServicioRepository : IEvento_ServicioRepository
    {
        public void CrearEvento_Servicio(Evento_Servicio obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Evento_Servicio.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarEvento_Servicios(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Servicio
                            where io.id_evento_servicio == id
                            select io;
                Evento_Servicio obj = query.FirstOrDefault();

                dataContext.Evento_Servicio.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Evento_Servicio> ListarPorEvento(int EventoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Servicio.Include("Evento").Include("Servicio")
                            where io.id_evento == EventoID
                            select io;
                List<Evento_Servicio> evento_servicios = query.ToList();
                return evento_servicios;
            }
        }

        public List<Evento_Servicio> ListarPorServicio(int ServicioID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Servicio.Include("Evento").Include("Servicio")
                            where io.id_servicio == ServicioID
                            select io;
                List<Evento_Servicio> evento_servicios = query.ToList();
                return evento_servicios;
            }
        }

        public List<Evento_Servicio> ObtenerEvento_Servicios()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Servicio.Include("Evento").Include("Servicio")
                            select io;
                List<Evento_Servicio> evento_servicios = query.ToList();
                return evento_servicios;
            }
        }
    }
}
