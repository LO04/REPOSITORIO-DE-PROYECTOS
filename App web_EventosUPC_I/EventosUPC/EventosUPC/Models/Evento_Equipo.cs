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
    
    public partial class Evento_Equipo
    {
        public int id_evento_equipo { get; set; }
        public int id_evento { get; set; }
        public int id_equipo { get; set; }
    
        public virtual Equipo Equipo { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
