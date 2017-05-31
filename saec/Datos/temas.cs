namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public temas()
        {
            agenda_aula = new HashSet<agenda_aula>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string modulo { get; set; }

        public int idlicencia { get; set; }

        public int idempresa { get; set; }

        public int horas { get; set; }

        public int idestado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_aula> agenda_aula { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual licencias licencias { get; set; }
    }
}
