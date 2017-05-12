using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoCancelacionDetalle
    {
        public int PagoCancelacionId { get; set; }
        public int PagoId { get; set; }
        public int? PagoParcialId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public TimeSpan HoraCancelacion { get; set; }
        public string Observaciones { get; set; }

        public virtual PagoCancelacion Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
