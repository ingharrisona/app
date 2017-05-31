namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sedes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sedes()
        {
            agenda_aula = new HashSet<agenda_aula>();
            aulas = new HashSet<aulas>();
        }

        public int id { get; set; }

        public int idempresa { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public int iddepartamento { get; set; }

        public int idmunicipio { get; set; }

        [Required]
        [StringLength(50)]
        public string barrio { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_aula> agenda_aula { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aulas> aulas { get; set; }

        public virtual departamentos departamentos { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual municipios municipios { get; set; }
    }
}
