using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLCliente
{
    public interface IClienteService
    {
        void CrearCliente(Cliente obj);
        List<Cliente> ObtenerClientes();
        void EliminarCliente(int id);
        void ActualizarCliente(Cliente obj);
        List<Cliente> NombreAscendente();
        List<Cliente> NombreDescendente();
    }
}
