using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaConsecutivo
    {
        public int AsociacionId { get; set; }
        public int PolizaTipoId { get; set; }
        public int PolizaSubtipoId { get; set; }
        public int Anio { get; set; }
        public int MesId { get; set; }
        public int Consecutivo { get; set; }

        public virtual Asociacion Asociacion { get; set; }
        public virtual Mes Mes { get; set; }
        public virtual PolizaSubtipo PolizaSubtipo { get; set; }
        public virtual PolizaTipo PolizaTipo { get; set; }
    }
}
