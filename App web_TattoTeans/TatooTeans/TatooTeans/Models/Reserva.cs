//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TatooTeans.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int ID { get; set; }
        public int ID_LocalPorUsuarioPorCategoria { get; set; }
        public System.DateTime FechaReserva { get; set; }
        public string Descripcion { get; set; }
        public int ID_Cliente { get; set; }
    
        public virtual LocalPorUsuarioPorCategoria LocalPorUsuarioPorCategoria { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}