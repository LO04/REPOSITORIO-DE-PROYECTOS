using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Evento_Personal
    {
        public string NombreEvento
        {
            set { }
            get { return this.Evento.nombre; }
        }

        public string NombrePersonal
        {
            set { }
            get { return this.Personal.nombre; }
        }
        public decimal Sueldo
        {
            set { }
            get { return this.Personal.sueldo; }
        }
    }
}
