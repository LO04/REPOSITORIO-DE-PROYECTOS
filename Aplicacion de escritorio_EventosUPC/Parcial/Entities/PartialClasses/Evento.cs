using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public partial class Evento
    {
        public string NombreLocal
        {
            set { }
            get { return this.Local.nombre; }
        }

        public string NombreCliente
        {
            set { }
            get { return this.Cliente.nombre; }
        }
    }
}
