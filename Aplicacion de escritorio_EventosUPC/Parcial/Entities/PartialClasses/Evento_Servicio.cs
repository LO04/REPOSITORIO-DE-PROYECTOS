using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Evento_Servicio
    {
        public string NombreEvento
        {
            set { }
            get { return this.Evento.nombre; }
        }

        public string NombreServicio
        {
            set { }
            get { return this.Servicio.nombre; }
        }
        public decimal PrecioAlquilerServicio
        {
            set { }
            get { return this.Servicio.precio_alquiler; }
        }
    }
}
