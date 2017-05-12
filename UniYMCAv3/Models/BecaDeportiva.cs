using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class BecaDeportiva
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public decimal MontoBeca { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public TimeSpan HoraAplicacion { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
