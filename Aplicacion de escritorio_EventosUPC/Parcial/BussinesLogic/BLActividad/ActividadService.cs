using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAActividad;

namespace BussinesLogic.BLActividad
{
    public class ActividadService : IActividadService
    {
        private IActividadRepository repository;
        private IActividadRepository Myrepository
        {

            get
            {
                if(repository == null)
                {
                    repository = new ActividadRepository();
                 }
                return repository;
     
            }

        }
        public List<Actividad> ObtenerActividades()
        {
            return Myrepository.ObtenerActividades();
        }
    }
}
