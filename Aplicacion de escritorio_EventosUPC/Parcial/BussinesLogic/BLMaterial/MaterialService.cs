using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAMaterial;

namespace BussinesLogic.BLMaterial
{
    public class MaterialService : IMaterialService

    {
        private IMaterialRepository repository;
        private IMaterialRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new MaterialRepository();
                }
                return repository;

            }

        }
        public List<Material> ObtenerMateriales()
        {
            return Myrepository.ObtenerMateriales();
        }
    }
}
