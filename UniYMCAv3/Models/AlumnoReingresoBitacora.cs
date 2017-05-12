using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoReingresoBitacora
    {
        public int BitacoraId { get; set; }
        public int UsuarioId { get; set; }
        public int AlumnoId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
