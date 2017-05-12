using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoDetalle
    {
        public int PagoParcialId { get; set; }
        public int PagoMetodoId { get; set; }
        public decimal Importe { get; set; }

        public virtual PagoMetodo PagoMetodo { get; set; }
        public virtual PagoParcial PagoParcial { get; set; }
    }
}
