//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESTADO_SOLICITUD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADO_SOLICITUD()
        {
            this.SOLICITUD = new HashSet<SOLICITUD>();
        }
    
        public int ID_ESTADO_SOLICITUD { get; set; }
        public string ESTADO_SOLICITUD1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}