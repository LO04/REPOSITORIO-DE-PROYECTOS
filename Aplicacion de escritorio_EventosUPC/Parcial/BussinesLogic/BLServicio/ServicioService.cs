using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAServicio;

namespace BussinesLogic.BLServicio
{
    public class ServicioService : IServicioService
    {
        private IServicioRepository repository;
        private IServicioRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new ServicioRepository();
                }
                return repository;

            }

        }
        public List<Servicio> ObtenerServicios()
        {
            return Myrepository.ObtenerServicios();
        }
    }
}
