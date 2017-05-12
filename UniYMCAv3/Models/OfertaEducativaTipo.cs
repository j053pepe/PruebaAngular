using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class OfertaEducativaTipo
    {
        public OfertaEducativaTipo()
        {
            CuotaIncremento = new HashSet<CuotaIncremento>();
            OfertaEducativa = new HashSet<OfertaEducativa>();
            OfertaEducativaPlan = new HashSet<OfertaEducativaPlan>();
            PeriodoAnticipado = new HashSet<PeriodoAnticipado>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int OfertaEducativaTipoId { get; set; }
        public int AntecedenteTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CuotaIncremento> CuotaIncremento { get; set; }
        public virtual ICollection<OfertaEducativa> OfertaEducativa { get; set; }
        public virtual ICollection<OfertaEducativaPlan> OfertaEducativaPlan { get; set; }
        public virtual ICollection<PeriodoAnticipado> PeriodoAnticipado { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
        public virtual AntecedenteTipo AntecedenteTipo { get; set; }
    }
}
