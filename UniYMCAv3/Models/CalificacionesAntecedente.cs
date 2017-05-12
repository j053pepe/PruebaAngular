using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class CalificacionesAntecedente
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public int? NoMaterias { get; set; }
        public string CalificacionMaterias { get; set; }
        public int? NoBajas { get; set; }
        public string BajaMaterias { get; set; }
    }
}
