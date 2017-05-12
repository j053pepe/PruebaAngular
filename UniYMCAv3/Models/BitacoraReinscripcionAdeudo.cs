using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class BitacoraReinscripcionAdeudo
    {
        public int AlumnoId { get; set; }
        public DateTime FechaOperacion { get; set; }
        public TimeSpan HoraOperacion { get; set; }
        public bool EsBiblioteca { get; set; }
        public bool EsChocolates { get; set; }
        public int UsuarioId { get; set; }
        public string Observaciones { get; set; }
        public bool EsActivo { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
