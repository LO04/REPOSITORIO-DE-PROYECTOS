using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.BLEvento_Personal
{
    public interface IEvento_PersonalService
    {
        void CrearEvento_Personal(Evento_Personal obj);
        List<Evento_Personal> ObtenerEvento_Personales();
        void EliminarEvento_Personales(int id);
        List<Evento_Personal> ListarPorEvento(int EventoID);
        List<Evento_Personal> ListarPorPersonal(int PersonalID);
    }
}
