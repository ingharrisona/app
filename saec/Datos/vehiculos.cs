namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vehiculos
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string marca { get; set; }

        [Required]
        [StringLength(20)]
        public string linea { get; set; }

        [Required]
        [StringLength(12)]
        public string placa { get; set; }

        [Required]
        [StringLength(20)]
        public string modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string serialmotor { get; set; }

        [Required]
        [StringLength(50)]
        public string serialchasis { get; set; }

        [Required]
        [StringLength(50)]
        public string numerosoat { get; set; }

        [Column(TypeName = "date")]
        public DateTime vencimientosoat { get; set; }

        [Column(TypeName = "date")]
        public DateTime vencimientortm { get; set; }

        public int? idestado { get; set; }

        public virtual estados estados { get; set; }
    }
}
