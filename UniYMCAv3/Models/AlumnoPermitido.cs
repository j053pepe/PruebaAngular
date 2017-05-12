using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoPermitido
    {
        public int AlumnoId { get; set; }
        public int UsuarioId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }
        public string Descripcion { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
