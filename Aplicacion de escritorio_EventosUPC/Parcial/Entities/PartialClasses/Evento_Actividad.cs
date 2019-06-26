using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Evento_Actividad
    {
        public string NombreEvento
        {
            set { }
            get { return this.Evento.nombre; }
        }

        public string NombreActividad
        {
            set { }
            get { return this.Actividad.nombre; }
        }
        
    }
}
