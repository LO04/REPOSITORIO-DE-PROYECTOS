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
    
    public partial class CompraDetalle
    {
        public int ID { get; set; }
        public int ID_Producto { get; set; }
        public int ID_FacturaCompra { get; set; }
        public int Cantidad { get; set; }
    
        public virtual FacturaCompra FacturaCompra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
