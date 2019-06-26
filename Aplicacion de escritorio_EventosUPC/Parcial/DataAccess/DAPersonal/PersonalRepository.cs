using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DAPersonal
{
    public class PersonalRepository : IPersonalRepository
    {
        public void ActualizarPersonal(Personal obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            { 
                var query = from io in dataContext.Personal
                            where io.id_personal==obj.id_personal
                            select io;
                Personal databasePersonal = query.FirstOrDefault();

                
                databasePersonal.nombre = obj.nombre;
                databasePersonal.cargo = obj.cargo;
                databasePersonal.sueldo = obj.sueldo;
                databasePersonal.DNI = obj.DNI;

                dataContext.SaveChanges();
            }
        }

        public void CrearPersonal(Personal obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Personal.Add(obj);
                dataContext.SaveChanges();
            }
        }

        public void EliminarPersonal(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Personal
                            where io.id_personal== id
                            select io;
                Personal obj = query.FirstOrDefault();

                dataContext.Personal.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Personal> NombreAscendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Personal
                            orderby io.nombre ascending 
                            select io;
                List<Personal> personales = query.ToList();
                return personales;
            }
        }

        public List<Personal> NombreDescendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Personal
                            orderby io.nombre descending
                            select io;
                List<Personal> personales = query.ToList();
                return personales;
            }
        }

        public List<Personal> ObtenerPersonales()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Personal
                            select io;
                List<Personal> personales = query.ToList();
                return personales;
            }
        }
    }
}
