using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoPasswordRecovery
    {
        public int AlumnoId { get; set; }
        public string Token { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public int EstatusId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}
