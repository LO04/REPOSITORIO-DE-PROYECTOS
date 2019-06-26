using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.DACliente
{
    public class ClienteRepository : IClienteRepository
    {
        public void ActualizarCliente(Cliente obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Cliente
                            where io.id_cliente == obj.id_cliente
                            select io;
                Cliente databaseCliente = query.FirstOrDefault();


                databaseCliente.nombre = obj.nombre;
                databaseCliente.apellido = obj.apellido;
                databaseCliente.celular = obj.celular;
                databaseCliente.DNI = obj.DNI;
                databaseCliente.direccion = obj.direccion;

                dataContext.SaveChanges();
            }
        }

        public void CrearCliente(Cliente obj)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                dataContext.Cliente.Add(obj);
                dataContext.SaveChanges();
            }
        }
        public void EliminarCliente(int id)
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Cliente
                            where io.id_cliente == id
                            select io;
                Cliente obj = query.FirstOrDefault();

                dataContext.Cliente.Remove(obj);
                dataContext.SaveChanges();
            }
        }

        public List<Cliente> NombreAscendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Cliente
                            orderby io.nombre ascending
                            select io;
                List<Cliente> cliente = query.ToList();
                return cliente;
            }
        }

        public List<Cliente> NombreDescendente()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Cliente
                            orderby io.nombre descending
                            select io;
                List<Cliente> cliente = query.ToList();
                return cliente;
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            using (var dataContext = new Eventos_TPEntitiesContext())
            {
                var query = from io in dataContext.Cliente
                            select io;
                List<Cliente> clientes = query.ToList();
                return clientes;
            }
        }
    }
}
