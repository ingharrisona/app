namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class personas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personas()
        {
            agenda_aula = new HashSet<agenda_aula>();
            agenda_persona = new HashSet<agenda_persona>();
            cotizaciones = new HashSet<cotizaciones>();
        }

        public int id { get; set; }

        public int idempresa { get; set; }

        [Required]
        [StringLength(50)]
        public string nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidos { get; set; }

        public int idtipodocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string documento { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? idrol { get; set; }

        public int? idgenero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechanacimiento { get; set; }

        public int? iddepartamento { get; set; }

        public int? idmunicipio { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string barrio { get; set; }

        [StringLength(50)]
        public string eps { get; set; }

        [StringLength(20)]
        public string telefono { get; set; }

        [StringLength(20)]
        public string celular { get; set; }

        public int? idestadocivil { get; set; }

        [Column(TypeName = "image")]
        public byte[] firma { get; set; }

        [Column(TypeName = "image")]
        public byte[] foto { get; set; }

        [Column(TypeName = "image")]
        public byte[] huella { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaingreso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_aula> agenda_aula { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_persona> agenda_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cotizaciones> cotizaciones { get; set; }

        public virtual departamentos departamentos { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual estadocivil estadocivil { get; set; }

        public virtual generos generos { get; set; }

        public virtual municipios municipios { get; set; }

        public virtual rol rol { get; set; }

        public virtual tipo_documentos tipo_documentos { get; set; }
    }
}
