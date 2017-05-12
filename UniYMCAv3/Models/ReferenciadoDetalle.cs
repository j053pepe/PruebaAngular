using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoDetalle
    {
        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Importe { get; set; }
        public TimeSpan HoraProcesado { get; set; }
        public DateTime FechaProcesado { get; set; }
        public bool EsReferenciado { get; set; }
        public int? ReferenciaProcesadaId { get; set; }

        public virtual ReferenciadoCabecero Pago { get; set; }
        public virtual ReferenciaProcesada ReferenciaProcesada { get; set; }
    }
}
