using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Evento_Equipo
    {
        public string NombreEvento
        {
            set { }
            get { return this.Evento.nombre; }
        }

        public string NombreEquipo
        {
            set { }
            get { return this.Equipo.nombre; }
        }
        public decimal PrecioAlquilerEquipo
        {
            set { }
            get { return this.Equipo.precio_alquiler; }
        }
    }
}
