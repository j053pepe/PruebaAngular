using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoRevision
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRevision { get; set; }
        public TimeSpan HoraRevision { get; set; }
        public bool InscripcionCompleta { get; set; }
        public int AsesoriaEspecial { get; set; }
        public int AdelantoMateria { get; set; }
        public string Observaciones { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
