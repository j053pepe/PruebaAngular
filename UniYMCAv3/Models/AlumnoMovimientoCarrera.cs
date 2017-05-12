using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoMovimientoCarrera
    {
        public int AlumnoMovimientoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public string Observaciones { get; set; }

        public virtual AlumnoMovimiento AlumnoMovimiento { get; set; }
    }
}
