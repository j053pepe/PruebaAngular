using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Cuota
    {
        public Cuota()
        {
            Financiamiento = new HashSet<Financiamiento>();
            GrupoDetalle = new HashSet<GrupoDetalle>();
            Pago = new HashSet<Pago>();
        }

        public int CuotaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int PagoConceptoId { get; set; }
        public decimal Monto { get; set; }
        public bool EsEmpresa { get; set; }

        public virtual ICollection<Financiamiento> Financiamiento { get; set; }
        public virtual ICollection<GrupoDetalle> GrupoDetalle { get; set; }
        public virtual LenguasRelacion LenguasRelacion { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual PagoConcepto PagoConcepto { get; set; }
    }
}
