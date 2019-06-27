//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventosUPC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Evento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Evento()
        {
            this.Evento_Actividad = new HashSet<Evento_Actividad>();
            this.Evento_Equipo = new HashSet<Evento_Equipo>();
            this.Evento_Material = new HashSet<Evento_Material>();
            this.Evento_Personal = new HashSet<Evento_Personal>();
            this.Evento_Servicio = new HashSet<Evento_Servicio>();
        }
    
        public int id_evento { get; set; }
        public int id_cliente { get; set; }
        public int id_local { get; set; }
        public string nombre { get; set; }
        public string objetivo { get; set; }
        public int nro_asistentes { get; set; }
        public System.DateTime fecha_evento { get; set; }
        public string encargado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Actividad> Evento_Actividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Equipo> Evento_Equipo { get; set; }
        public virtual Local Local { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Material> Evento_Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Personal> Evento_Personal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evento_Servicio> Evento_Servicio { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
