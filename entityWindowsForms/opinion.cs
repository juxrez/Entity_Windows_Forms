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
    
    public partial class opinion
    {
        public int id_opinion { get; set; }
        public int id_usuario_receptor { get; set; }
        public int id_usuario_emisor { get; set; }
        public string opinion_comentario { get; set; }
        public System.DateTime opinion_fecha { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}
