using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLEvento
{
    public interface IEventoService
    {
        void CrearEvento(Evento obj);
        List<Evento> ObtenerEventos();
        List<Evento> ObtenerEventosporLocal(int idL);
        List<Evento> ObtenerEventosporCliente(int idC);
        void EliminarEvento(int id);
        void ActualizarEvento(Evento obj);
        List<Evento> listarPorFecha(DateTime fechaInicio, DateTime fechafin);
    }
}
