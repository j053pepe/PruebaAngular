using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoGrupoCuota
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public decimal MontoColegiatura { get; set; }
        public decimal MontoInscripcion { get; set; }
        public int GrupoId { get; set; }
    }
}
