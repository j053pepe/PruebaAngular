using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PeriodoAnticipado
    {
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int PeriodoAnticipadoId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal ImporteDescuento { get; set; }
        public int OfertaEducativaTipoId { get; set; }
        public int PagoConceptoId { get; set; }

        public virtual OfertaEducativaTipo OfertaEducativaTipo { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
