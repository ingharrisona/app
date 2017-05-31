namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class agenda_aula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agenda_aula()
        {
            agenda_persona = new HashSet<agenda_persona>();
            cotizaciones = new HashSet<cotizaciones>();
        }

        public int id { get; set; }

        public int idempresa { get; set; }

        public int idsede { get; set; }

        public int idaula { get; set; }

        public int idtema { get; set; }

        public int idinstructor { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public int idhora { get; set; }

        public int? idestado { get; set; }

        public virtual aulas aulas { get; set; }

        public virtual estados estados { get; set; }

        public virtual horas horas { get; set; }

        public virtual personas personas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agenda_persona> agenda_persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cotizaciones> cotizaciones { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual sedes sedes { get; set; }

        public virtual temas temas { get; set; }
    }
}
