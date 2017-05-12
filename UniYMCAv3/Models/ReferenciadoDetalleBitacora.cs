using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoDetalleBitacora
    {
        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Importe { get; set; }
        public TimeSpan HoraProcesado { get; set; }
        public DateTime FechaProcesado { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaBitacora { get; set; }
        public string Observaciones { get; set; }

        public virtual ReferenciadoCabeceroBitacora Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
