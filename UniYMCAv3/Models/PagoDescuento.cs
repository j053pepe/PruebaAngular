using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoDescuento
    {
        public int PagoId { get; set; }
        public int DescuentoId { get; set; }
        public decimal Monto { get; set; }

        public virtual Descuento Descuento { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
