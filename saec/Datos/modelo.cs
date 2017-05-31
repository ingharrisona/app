namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class modelo : DbContext
    {
        public modelo()
            : base("name=modelo")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<agenda_aula> agenda_aula { get; set; }
        public virtual DbSet<agenda_persona> agenda_persona { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<aulas> aulas { get; set; }
        public virtual DbSet<cotizaciones> cotizaciones { get; set; }
        public virtual DbSet<departamentos> departamentos { get; set; }
        public virtual DbSet<empresas> empresas { get; set; }
        public virtual DbSet<estadocivil> estadocivil { get; set; }
        public virtual DbSet<estados> estados { get; set; }
        public virtual DbSet<generos> generos { get; set; }
        public virtual DbSet<horas> horas { get; set; }
        public virtual DbSet<ivas> ivas { get; set; }
        public virtual DbSet<licencias> licencias { get; set; }
        public virtual DbSet<municipios> municipios { get; set; }
        public virtual DbSet<personas> personas { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<sedes> sedes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<temas> temas { get; set; }
        public virtual DbSet<tipo_documentos> tipo_documentos { get; set; }
        public virtual DbSet<vehiculos> vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<agenda_aula>()
                .HasMany(e => e.agenda_persona)
                .WithRequired(e => e.agenda_aula)
                .HasForeignKey(e => e.idagendaaula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<agenda_aula>()
                .HasMany(e => e.cotizaciones)
                .WithRequired(e => e.agenda_aula)
                .HasForeignKey(e => e.idagendapersona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aulas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<aulas>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.aulas)
                .HasForeignKey(e => e.idaula)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<departamentos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<departamentos>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<departamentos>()
                .HasMany(e => e.municipios)
                .WithRequired(e => e.departamentos)
                .HasForeignKey(e => e.iddepartamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<departamentos>()
                .HasMany(e => e.municipios1)
                .WithRequired(e => e.departamentos1)
                .HasForeignKey(e => e.iddepartamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<departamentos>()
                .HasMany(e => e.personas)
                .WithOptional(e => e.departamentos)
                .HasForeignKey(e => e.iddepartamento);

            modelBuilder.Entity<departamentos>()
                .HasMany(e => e.sedes)
                .WithRequired(e => e.departamentos)
                .HasForeignKey(e => e.iddepartamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<empresas>()
                .Property(e => e.nit)
                .IsUnicode(false);

            modelBuilder.Entity<empresas>()
                .Property(e => e.representante)
                .IsUnicode(false);

            modelBuilder.Entity<empresas>()
                .Property(e => e.resolucion)
                .IsUnicode(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.aulas)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.cotizaciones)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.personas)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.sedes)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresas>()
                .HasMany(e => e.temas)
                .WithRequired(e => e.empresas)
                .HasForeignKey(e => e.idempresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estadocivil>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<estadocivil>()
                .HasMany(e => e.personas)
                .WithOptional(e => e.estadocivil)
                .HasForeignKey(e => e.idestadocivil);

            modelBuilder.Entity<estados>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .HasMany(e => e.agenda_aula)
                .WithOptional(e => e.estados)
                .HasForeignKey(e => e.idestado);

            modelBuilder.Entity<estados>()
                .HasMany(e => e.agenda_persona)
                .WithOptional(e => e.estados)
                .HasForeignKey(e => e.idestado);

            modelBuilder.Entity<estados>()
                .HasMany(e => e.empresas)
                .WithOptional(e => e.estados)
                .HasForeignKey(e => e.idestado);

            modelBuilder.Entity<estados>()
                .HasMany(e => e.vehiculos)
                .WithOptional(e => e.estados)
                .HasForeignKey(e => e.idestado);

            modelBuilder.Entity<generos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<generos>()
                .HasMany(e => e.personas)
                .WithOptional(e => e.generos)
                .HasForeignKey(e => e.idgenero);

            modelBuilder.Entity<horas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<horas>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.horas)
                .HasForeignKey(e => e.idhora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ivas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ivas>()
                .HasMany(e => e.licencias)
                .WithOptional(e => e.ivas)
                .HasForeignKey(e => e.idiva);

            modelBuilder.Entity<licencias>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<licencias>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<licencias>()
                .Property(e => e.Precio)
                .HasPrecision(10, 0);

            modelBuilder.Entity<licencias>()
                .HasMany(e => e.cotizaciones)
                .WithRequired(e => e.licencias)
                .HasForeignKey(e => e.idlicencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<licencias>()
                .HasMany(e => e.temas)
                .WithRequired(e => e.licencias)
                .HasForeignKey(e => e.idlicencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<municipios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<municipios>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<municipios>()
                .HasMany(e => e.personas)
                .WithOptional(e => e.municipios)
                .HasForeignKey(e => e.idmunicipio);

            modelBuilder.Entity<municipios>()
                .HasMany(e => e.sedes)
                .WithRequired(e => e.municipios)
                .HasForeignKey(e => e.idmunicipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.documento)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.barrio)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.eps)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<personas>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.personas)
                .HasForeignKey(e => e.idinstructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<personas>()
                .HasMany(e => e.agenda_persona)
                .WithRequired(e => e.personas)
                .HasForeignKey(e => e.idpersona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<personas>()
                .HasMany(e => e.cotizaciones)
                .WithRequired(e => e.personas)
                .HasForeignKey(e => e.idpersona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rol>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<rol>()
                .HasMany(e => e.personas)
                .WithOptional(e => e.rol)
                .HasForeignKey(e => e.idrol);

            modelBuilder.Entity<sedes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<sedes>()
                .Property(e => e.barrio)
                .IsUnicode(false);

            modelBuilder.Entity<sedes>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<sedes>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.sedes)
                .HasForeignKey(e => e.idsede)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sedes>()
                .HasMany(e => e.aulas)
                .WithRequired(e => e.sedes)
                .HasForeignKey(e => e.idsede)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<temas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<temas>()
                .Property(e => e.modulo)
                .IsUnicode(false);

            modelBuilder.Entity<temas>()
                .HasMany(e => e.agenda_aula)
                .WithRequired(e => e.temas)
                .HasForeignKey(e => e.idtema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_documentos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_documentos>()
                .HasMany(e => e.personas)
                .WithRequired(e => e.tipo_documentos)
                .HasForeignKey(e => e.idtipodocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.marca)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.linea)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.placa)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.modelo)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.serialmotor)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.serialchasis)
                .IsUnicode(false);

            modelBuilder.Entity<vehiculos>()
                .Property(e => e.numerosoat)
                .IsUnicode(false);
        }
    }
}
