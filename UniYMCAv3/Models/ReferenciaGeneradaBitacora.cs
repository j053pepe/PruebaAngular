using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciaGeneradaBitacora
    {
        public int PagoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }

        public virtual Pago Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
