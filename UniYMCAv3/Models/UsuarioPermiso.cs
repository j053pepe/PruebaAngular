using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioPermiso
    {
        public int UsuarioId { get; set; }
        public int IngresosId { get; set; }
        public int UsuarioIdAsignacion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public TimeSpan HoraAsignacion { get; set; }

        public virtual IngresosPermiso Ingresos { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario UsuarioIdAsignacionNavigation { get; set; }
    }
}
