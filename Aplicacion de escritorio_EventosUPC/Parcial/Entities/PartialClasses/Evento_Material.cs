using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public partial class Evento_Material
    {
        public string NombreEvento
        {
            set { }
            get { return this.Evento.nombre; }
        }

        public string NombreMaterial
        {
            set { }
            get { return this.Material.nombre; }
        }
        public decimal PrecioAlquilerMaterial
        {
            set { }
            get { return this.Material.precio_alquiler; }
        }
    }
}
