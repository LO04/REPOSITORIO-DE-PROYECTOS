using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAEvento_Material
{
    public class Evento_MaterialRepository : IEvento_MaterialRepository
    {
        public void CrearEvento_Material(Evento_Material obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Evento_Material.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarEvento_Materiales(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Material
                            where io.id_evento_material == id
                            select io;
                Evento_Material obj = query.FirstOrDefault();

                dataContext.Evento_Material.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Evento_Material> ListarPorEvento(int EventoID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Material.Include("Evento").Include("Material")
                            where io.id_evento == EventoID
                            select io;
                List<Evento_Material> evento_materiales = query.ToList();
                return evento_materiales;
            }
        }

        public List<Evento_Material> ListarPorMaterial(int MaterialID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Material.Include("Evento").Include("Material")
                            where io.id_material == MaterialID
                            select io;
                List<Evento_Material> evento_materiales = query.ToList();
                return evento_materiales;
            }
        }

        public List<Evento_Material> ObtenerEvento_Materiales()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Evento_Material.Include("Evento").Include("Material")
                            select io;
                List<Evento_Material> evento_materiales = query.ToList();
                return evento_materiales;
            }
        }
    }
}
