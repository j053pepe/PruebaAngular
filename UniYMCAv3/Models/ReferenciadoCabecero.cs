using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoCabecero
    {
        public ReferenciadoCabecero()
        {
            ReferenciadoDetalle = new HashSet<ReferenciadoDetalle>();
        }

        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public decimal ImporteRestante { get; set; }
        public decimal ImporteTotal { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<ReferenciadoDetalle> ReferenciadoDetalle { get; set; }
        public virtual Pago Pago { get; set; }
    }
}
