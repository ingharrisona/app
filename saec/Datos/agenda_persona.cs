namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class agenda_persona
    {
        public int id { get; set; }

        public int idpersona { get; set; }

        public int idagendaaula { get; set; }

        public int? idestado { get; set; }

        public DateTime? creada { get; set; }

        public virtual agenda_aula agenda_aula { get; set; }

        public virtual estados estados { get; set; }

        public virtual personas personas { get; set; }
    }
}
