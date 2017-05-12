using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoDescuentoPendiente
    {
        public int AlumnoDescuentoId { get; set; }
        public DateTime FechaPendiente { get; set; }
        public TimeSpan HoraPendiente { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public TimeSpan HoraAplicacion { get; set; }
        public int UsuarioIdAplicacion { get; set; }
        public int EstatusId { get; set; }

        public virtual AlumnoDescuento AlumnoDescuento { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
