using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento_Material;

namespace BussinesLogic.BLEvento_Material
{
    public class Evento_MaterialService : IEvento_MaterialService
    {
        private IEvento_MaterialRepository repository;
        private IEvento_MaterialRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new Evento_MaterialRepository();
                }
                return repository;

            }

        }
        public void CrearEvento_Material(Evento_Material obj)
        {
            Myrepository.CrearEvento_Material(obj);
        }

        public void EliminarEvento_Materiales(int id)
        {
            Myrepository.EliminarEvento_Materiales(id);
        }

        public List<Evento_Material> ListarPorMaterial(int MaterialID)
        {
            return Myrepository.ListarPorMaterial(MaterialID);
        }

        public List<Evento_Material> ListarPorEvento(int EventoID)
        {
            return Myrepository.ListarPorEvento(EventoID);
        }

        public List<Evento_Material> ObtenerEvento_Materiales()
        {
            return Myrepository.ObtenerEvento_Materiales();
        }

      
    }
}
