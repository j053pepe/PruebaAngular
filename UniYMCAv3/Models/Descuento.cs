using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Descuento
    {
        public Descuento()
        {
            PagoDescuento = new HashSet<PagoDescuento>();
        }

        public int DescuentoId { get; set; }
        public int PagoConceptoId { get; set; }
        public int DescuentoTipoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoMinimo { get; set; }
        public decimal MontoMaximo { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string CuentaContable { get; set; }

        public virtual ICollection<PagoDescuento> PagoDescuento { get; set; }
        public virtual DescuentoTipo DescuentoTipo { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual PagoConcepto PagoConcepto { get; set; }
    }
}
