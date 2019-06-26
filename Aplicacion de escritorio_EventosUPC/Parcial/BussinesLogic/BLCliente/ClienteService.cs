using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DACliente;

namespace BussinesLogic.BLCliente
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository repository;
        private IClienteRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new ClienteRepository();
                }
                return repository;

            }

        }
        public void ActualizarCliente(Cliente obj)
        {
            Myrepository.ActualizarCliente(obj);
        }

        public void CrearCliente(Cliente obj)
        {
            Myrepository.CrearCliente(obj);
        }

        public void EliminarCliente(int id)
        {
            Myrepository.EliminarCliente(id);
        }

        public List<Cliente> NombreAscendente()
        {
            return Myrepository.NombreAscendente();
        }

        public List<Cliente> NombreDescendente()
        {
            return Myrepository.NombreDescendente();
        }

        public List<Cliente> ObtenerClientes()
        {
            return Myrepository.ObtenerClientes();
        }
    }
}
