//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityWindowsForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class paquete
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public paquete()
        {
            this.usuarios = new HashSet<usuario>();
        }
    
        public int id_paquete { get; set; }
        public int id_rol { get; set; }
        public string paquete_nombre { get; set; }
        public decimal paquete_precio { get; set; }
        public int paquete_inmuebles_permitidos { get; set; }
        public System.DateTime paquete_fecha_vigencia { get; set; }
    
        public virtual rol rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}
