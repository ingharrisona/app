namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aulas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aulas()
        {
            agenda_aula = new HashSet<agenda_aula>();
        }

        public int id { get; set; }

        public int idempresa { get; set; }

        public int idsede { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        public int? ancho { get; set; }

        public int? largo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_aula> agenda_aula { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual sedes sedes { get; set; }
    }
}
