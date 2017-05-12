using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoMovimientoBaja
    {
        public int AlumnoMovimientoId { get; set; }
        public int BajaMotivoId { get; set; }
        public string Observaciones { get; set; }

        public virtual AlumnoMovimiento AlumnoMovimiento { get; set; }
        public virtual BajaMotivo BajaMotivo { get; set; }
    }
}
