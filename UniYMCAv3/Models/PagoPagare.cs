using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoPagare
    {
        public int PagoId { get; set; }
        public int PagareId { get; set; }
        public string ReferenciaId { get; set; }

        public virtual Pagare Pagare { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
