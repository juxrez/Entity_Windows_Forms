﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class allisonEntities : DbContext
    {
        public allisonEntities()
            : base("name=allisonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<auxiliar_idioma> auxiliar_idioma { get; set; }
        public virtual DbSet<clasificacion> clasificacions { get; set; }
        public virtual DbSet<contacto> contactoes { get; set; }
        public virtual DbSet<credito> creditoes { get; set; }
        public virtual DbSet<detalle_usuario> detalle_usuario { get; set; }
        public virtual DbSet<favorito> favoritoes { get; set; }
        public virtual DbSet<foto> fotoes { get; set; }
        public virtual DbSet<idioma> idiomas { get; set; }
        public virtual DbSet<inmueble> inmuebles { get; set; }
        public virtual DbSet<operacion> operacions { get; set; }
        public virtual DbSet<opinion> opinions { get; set; }
        public virtual DbSet<paquete> paquetes { get; set; }
        public virtual DbSet<ranking> rankings { get; set; }
        public virtual DbSet<rol> rols { get; set; }
        public virtual DbSet<servicio> servicios { get; set; }
        public virtual DbSet<tipo_foto> tipo_foto { get; set; }
        public virtual DbSet<tipo_inmueble> tipo_inmueble { get; set; }
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
    }
}
