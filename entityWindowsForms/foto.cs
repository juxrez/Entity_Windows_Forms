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
    
    public partial class foto
    {
        public int id_foto { get; set; }
        public int id_inmueble { get; set; }
        public int id_tipo_foto { get; set; }
        public string foto_url { get; set; }
    
        public virtual inmueble inmueble { get; set; }
        public virtual tipo_foto tipo_foto { get; set; }
    }
}