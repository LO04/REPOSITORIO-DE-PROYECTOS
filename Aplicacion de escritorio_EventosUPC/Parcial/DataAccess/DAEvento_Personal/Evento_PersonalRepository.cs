using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEvento_Personal
{
    public class Evento_PersonalRepository : IEvento_PersonalRepository
    {
        public void CrearEvento_Personal(Evento_Personal obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Evento_Personal.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarEvento_Personales(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Personal
                            where io.id_evento_personal == id
                            select io;
                Evento_Personal obj = query.FirstOrDefault();

                dataContext.Evento_Personal.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Evento_Personal> ListarPorEvento(int EventoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Personal.Include("Evento").Include("Personal")
                            where io.id_evento == EventoID
                            select io;
                List<Evento_Personal> evento_personales = query.ToList();
                return evento_personales;
            }
        }

        public List<Evento_Personal> ListarPorPersonal(int PersonalID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Personal.Include("Evento").Include("Personal")
                            where io.id_personal == PersonalID
                            select io;
                List<Evento_Personal> evento_personales = query.ToList();
                return evento_personales;
            }
        }

        public List<Evento_Personal> ObtenerEvento_Personales()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Personal.Include("Evento").Include("Personal")
                            select io;
                List<Evento_Personal> evento_personales = query.ToList();
                return evento_personales;
            }
        }
    }
}
