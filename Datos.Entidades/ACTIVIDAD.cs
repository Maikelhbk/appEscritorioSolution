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
    
    public partial class ACTIVIDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVIDAD()
        {
            this.DETALLE_ACTIVIDAD = new HashSet<DETALLE_ACTIVIDAD>();
            this.PROFESIONAL = new HashSet<PROFESIONAL>();
        }
    
        public int ID_ACTIVIDAD { get; set; }
        public string NOMBRE_ACTIVIDAD { get; set; }
        public string VALOR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ACTIVIDAD> DETALLE_ACTIVIDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROFESIONAL> PROFESIONAL { get; set; }
    }
}