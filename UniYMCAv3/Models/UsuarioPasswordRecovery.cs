using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioPasswordRecovery
    {
        public int UsuarioId { get; set; }
        public string Token { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public int EstatusId { get; set; }

        public virtual Estatus Estatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
