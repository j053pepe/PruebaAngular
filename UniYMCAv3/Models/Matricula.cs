using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Matricula
    {
        public string MatriculaId { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int UsuarioId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
