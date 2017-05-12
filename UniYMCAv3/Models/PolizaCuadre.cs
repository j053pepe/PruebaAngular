using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaCuadre
    {
        public DateTime FechaGeneracion { get; set; }
        public int PolizaTipoId { get; set; }
        public int PolizaSubtipoId { get; set; }
        public decimal ImporteAjuste { get; set; }
        public int AsociacionId { get; set; }

        public virtual Asociacion Asociacion { get; set; }
        public virtual PolizaSubtipo PolizaSubtipo { get; set; }
        public virtual PolizaTipo PolizaTipo { get; set; }
    }
}
