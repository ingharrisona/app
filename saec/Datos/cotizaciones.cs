namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cotizaciones
    {
        public int id { get; set; }

        public int idempresa { get; set; }

        public int idlicencia { get; set; }

        public int idpersona { get; set; }

        public int idagendapersona { get; set; }

        public DateTime? fecha { get; set; }

        public virtual agenda_aula agenda_aula { get; set; }

        public virtual empresas empresas { get; set; }

        public virtual licencias licencias { get; set; }

        public virtual personas personas { get; set; }
    }
}
