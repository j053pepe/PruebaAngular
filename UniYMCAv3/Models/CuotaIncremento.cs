using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class CuotaIncremento
    {
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public decimal ImporteIncremento { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaAutorizacion { get; set; }
        public TimeSpan HoraAutorizacion { get; set; }
        public string Observaciones { get; set; }
        public int OfertaEducativaTipoId { get; set; }
        public int PagoConceptoId { get; set; }

        public virtual OfertaEducativaTipo OfertaEducativaTipo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
