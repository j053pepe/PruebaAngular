using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoImagenDetalle
    {
        public int AlumnoId { get; set; }
        public string Extension { get; set; }
        public DateTime FechaCarga { get; set; }
        public TimeSpan HoraCarga { get; set; }
        public int UsuarioIdCarga { get; set; }

        public virtual AlumnoImagen Alumno { get; set; }
    }
}
