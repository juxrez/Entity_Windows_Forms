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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.auxiliar_idioma = new HashSet<auxiliar_idioma>();
            this.detalle_usuario = new HashSet<detalle_usuario>();
            this.favoritoes = new HashSet<favorito>();
            this.inmuebles = new HashSet<inmueble>();
            this.opinions = new HashSet<opinion>();
            this.opinions1 = new HashSet<opinion>();
            this.rankings = new HashSet<ranking>();
            this.rankings1 = new HashSet<ranking>();
        }
    
        public int id_usuario { get; set; }
        public string id_account { get; set; }
        public Nullable<int> id_tipo_usuario { get; set; }
        public Nullable<int> id_paquete { get; set; }
        public Nullable<int> id_clasificacion { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_apellido_paterno { get; set; }
        public string usuario_apellido_materno { get; set; }
        public string usuario_nombre_fiscal { get; set; }
        public string usuario_nombre_comercial { get; set; }
        public string usuario_nombre_responsable { get; set; }
        public string usuario_sexo { get; set; }
        public string usuario_correo { get; set; }
        public string usuario_calle { get; set; }
        public string usuario_numero_exterior { get; set; }
        public string usuario_numero_interior { get; set; }
        public string usuario_colonia { get; set; }
        public Nullable<int> usuario_codigo_postal { get; set; }
        public string usuario_localidad { get; set; }
        public string usuario_municipio { get; set; }
        public string usuario_estado { get; set; }
        public string usuario_pais { get; set; }
        public string usuario_telefono { get; set; }
        public string usuario_celular { get; set; }
        public string usuario_sitio_web { get; set; }
        public System.DateTime usuario_fecha_registro { get; set; }
        public string usuario_foto_url { get; set; }
        public Nullable<decimal> usuario_latitud { get; set; }
        public Nullable<decimal> usuario_longitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auxiliar_idioma> auxiliar_idioma { get; set; }
        public virtual clasificacion clasificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalle_usuario> detalle_usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favorito> favoritoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inmueble> inmuebles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<opinion> opinions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<opinion> opinions1 { get; set; }
        public virtual paquete paquete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ranking> rankings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ranking> rankings1 { get; set; }
        public virtual tipo_usuario tipo_usuario { get; set; }
    }
}
