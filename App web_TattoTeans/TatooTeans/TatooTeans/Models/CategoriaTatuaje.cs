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
    
    public partial class CategoriaTatuaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriaTatuaje()
        {
            this.UsuarioPorCategorias = new HashSet<UsuarioPorCategoria>();
        }
    
        public int ID { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioPorCategoria> UsuarioPorCategorias { get; set; }
    }
}
