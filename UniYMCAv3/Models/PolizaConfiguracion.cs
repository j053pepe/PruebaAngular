using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaConfiguracion
    {
        public int AsociacionId { get; set; }
        public int PolizaTipoId { get; set; }
        public int PolizaSubtipoId { get; set; }
        public string Directorio { get; set; }
        public string ArchivoFormato { get; set; }
        public string ArchivoTipo { get; set; }

        public virtual Asociacion Asociacion { get; set; }
        public virtual PolizaSubtipo PolizaSubtipo { get; set; }
        public virtual PolizaTipo PolizaTipo { get; set; }
    }
}
