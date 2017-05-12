using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoCabeceroBitacora
    {
        public ReferenciadoCabeceroBitacora()
        {
            ReferenciadoDetalleBitacora = new HashSet<ReferenciadoDetalleBitacora>();
        }

        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public decimal ImporteRestante { get; set; }
        public decimal ImporteTotal { get; set; }
        public int EstatusId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaBitacora { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<ReferenciadoDetalleBitacora> ReferenciadoDetalleBitacora { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
