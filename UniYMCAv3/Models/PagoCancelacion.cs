using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoCancelacion
    {
        public PagoCancelacion()
        {
            PagoCancelacionDetalle = new HashSet<PagoCancelacionDetalle>();
        }

        public int PagoId { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<PagoCancelacionDetalle> PagoCancelacionDetalle { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
