using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoExamenMedico
    {
        public int AlumnoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }
        public string Observaciones { get; set; }

        public virtual AlumnoDetalle Alumno { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
