using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoRecargo
    {
        public int PagoRecargoId { get; set; }
        public int PagoId { get; set; }
        public int PagoIdRecargo { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Pago Pago { get; set; }
        public virtual Pago PagoIdRecargoNavigation { get; set; }
    }
}
