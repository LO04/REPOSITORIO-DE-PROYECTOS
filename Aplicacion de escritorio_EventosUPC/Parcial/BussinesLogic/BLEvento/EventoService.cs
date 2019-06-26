using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.DAEvento;

namespace BussinesLogic.BLEvento
{
    public class EventoService : IEventoService
    {
        private IEventoRepository repository;
        private IEventoRepository Myrepository
        {

            get
            {
                if (repository == null)
                {
                    repository = new EventoRepository();
                }
                return repository;

            }

        }
        public void ActualizarEvento(Evento obj)
        {
            Myrepository.ActualizarEvento(obj);
        }

        public void CrearEvento(Evento obj)
        {
            Myrepository.CrearEvento(obj);
        }

        public void EliminarEvento(int id)
        {
            Myrepository.EliminarEvento(id);
        }

        public List<Evento> listarPorFecha(DateTime fechaInicio, DateTime fechafin)
        {
            return Myrepository.listarPorFecha(fechaInicio,fechafin);
        }

        public List<Evento> ObtenerEventos()
        {
            return Myrepository.ObtenerEventos();
        }

        public List<Evento> ObtenerEventosporCliente(int idC)
        {
            return Myrepository.ObtenerEventosporCliente(idC);
        }

        public List<Evento> ObtenerEventosporLocal(int idL)
        {
            return Myrepository.ObtenerEventosporLocal(idL);
        }
    }
}
