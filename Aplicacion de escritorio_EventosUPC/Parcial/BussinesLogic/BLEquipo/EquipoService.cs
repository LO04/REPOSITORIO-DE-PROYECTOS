using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEquipo;

namespace BussinesLogic.BLEquipo
{
    public class EquipoService : IEquipoService
    {
        private IEquipoRepository repository;
        private IEquipoRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new EquipoRepository();
                }
                return repository;

            }

        }
        public List<Equipo> ObtenerEquipos()
        {
            return Myrepository.ObtenerEquipos();
        }
    }
}
