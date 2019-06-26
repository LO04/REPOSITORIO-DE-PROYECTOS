using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAEvento_Servicio
{
    public interface IEvento_ServicioRepository
    {
        void CrearEvento_Servicio(Evento_Servicio obj);
        List<Evento_Servicio> ObtenerEvento_Servicios();
        void EliminarEvento_Servicios(int id);
        List<Evento_Servicio> ListarPorEvento(int EventoID);
        List<Evento_Servicio> ListarPorServicio(int ServicioID);
    }
}
