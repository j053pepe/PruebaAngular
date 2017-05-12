using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AdeudoChocolates
    {
        public int AlumnoId { get; set; }
        public DateTime FechaOperacion { get; set; }
        public string Observaciones { get; set; }
        public int UsuarioId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Usuario AlumnoNavigation { get; set; }
    }
}
