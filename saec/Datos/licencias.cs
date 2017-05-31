namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class licencias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public licencias()
        {
            cotizaciones = new HashSet<cotizaciones>();
            temas = new HashSet<temas>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int teoricas { get; set; }

        public int practicas { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Precio { get; set; }

        public int? idiva { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cotizaciones> cotizaciones { get; set; }

        public virtual ivas ivas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<temas> temas { get; set; }
    }
}
