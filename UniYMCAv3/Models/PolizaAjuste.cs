using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaAjuste
    {
        public int PagoId { get; set; }
        public DateTime FechaAjuste { get; set; }
        public decimal Importe { get; set; }
        public string CuentaOrigen { get; set; }
        public string CuentaDestino { get; set; }
        public int EstatusId { get; set; }

        public virtual Estatus Estatus { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
