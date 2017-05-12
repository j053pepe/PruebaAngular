using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoParcial
    {
        public PagoParcial()
        {
            PagoDetalle = new HashSet<PagoDetalle>();
            Reclasificacion = new HashSet<Reclasificacion>();
        }

        public int PagoParcialId { get; set; }
        public int PagoId { get; set; }
        public int? SucursalCajaId { get; set; }
        public int? ReciboId { get; set; }
        public decimal Pago { get; set; }
        public DateTime FechaPago { get; set; }
        public TimeSpan HoraPago { get; set; }
        public int EstatusId { get; set; }
        public bool TieneMovimientos { get; set; }
        public int PagoTipoId { get; set; }
        public int ReferenciaProcesadaId { get; set; }

        public virtual ICollection<PagoDetalle> PagoDetalle { get; set; }
        public virtual ICollection<Reclasificacion> Reclasificacion { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Pago PagoNavigation { get; set; }
        public virtual PagoTipo PagoTipo { get; set; }
        public virtual ReferenciaProcesada ReferenciaProcesada { get; set; }
        public virtual Recibo Recibo { get; set; }
    }
}
