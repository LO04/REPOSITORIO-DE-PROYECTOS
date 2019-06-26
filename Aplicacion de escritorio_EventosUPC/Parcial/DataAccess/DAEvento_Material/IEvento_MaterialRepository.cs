using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAEvento_Material
{
    public interface IEvento_MaterialRepository
    {
        void CrearEvento_Material(Evento_Material obj);
        List<Evento_Material> ObtenerEvento_Materiales();
        void EliminarEvento_Materiales(int id);
        List<Evento_Material> ListarPorEvento(int EventoID);
        List<Evento_Material> ListarPorMaterial(int MaterialID);
    }
}
