using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DALocal
{
    public class LocalRepository : ILocalRepository
    {
        public void ActualizarLocal(Local objLocal)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Local
                            where io.id_local == objLocal.id_local
                            select io;
                Local databaseLocal = query.FirstOrDefault();


                databaseLocal.nombre = objLocal.nombre;
                databaseLocal.direccion = objLocal.direccion;
                databaseLocal.capacidad = objLocal.capacidad;
            
                dataContext.SaveChanges();
            }
        }

        public void EliminarLocal(int LocalID)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Local
                            where io.id_local == LocalID
                            select io;
                Local obj = query.FirstOrDefault();

                dataContext.Local.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Local> ListarLocales()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Local
                            select io;
                List<Local> locales = query.ToList();
                return locales;
            }
        }

        public List<Local> NombreAscendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Local
                            orderby io.nombre ascending
                            select io;
                List<Local> local = query.ToList();
                return local;
            }
        }

        public List<Local> NombreDescendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Local
                            orderby io.nombre descending
                            select io;
                List<Local> local = query.ToList();
                return local;
            }
        }

        public void RegistrarLocal(Local objLocal)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Local.Add(objLocal);
                dataContext.SaveChanges();
            }
        }
  
    }
}
