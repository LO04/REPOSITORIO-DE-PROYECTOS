using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAEvento_Actividad
{
    public interface IEvento_ActividadRepository
    {
        void CrearEvento_Actividad(Evento_Actividad obj);
        List<Evento_Actividad> ObtenerEvento_Actividades();
        void EliminarEvento_Actividades(int id);

        List<Evento_Actividad> listarPorEvento(int EventoID);
        List<Evento_Actividad> listarPorActividad(int ActividadID);

    }
}
