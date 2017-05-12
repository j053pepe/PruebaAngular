using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Adeudo
    {
        public int AlumnoId { get; set; }
        public decimal ColegiaturaIdiomas { get; set; }
        public decimal Colegiatura { get; set; }
        public decimal Inscripcion { get; set; }
        public decimal Financiamiento { get; set; }
        public decimal Pagare { get; set; }
        public int? OfertaEducativaId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
