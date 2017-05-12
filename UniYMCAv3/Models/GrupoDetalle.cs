using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class GrupoDetalle
    {
        public int GrupoId { get; set; }
        public decimal PorcentajeInscripcion { get; set; }
        public decimal? PorcentajeColegiatura { get; set; }
        public bool SiempreInscripcion { get; set; }
        public int NoPagos { get; set; }
        public int CuotaId { get; set; }
        public bool EsCuotaCongelada { get; set; }

        public virtual Cuota Cuota { get; set; }
        public virtual Grupo Grupo { get; set; }
    }
}
