using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaCompuesta
    {
        public int PreguntaConfiguracionId { get; set; }
        public int? PreguntaTipoValoresId { get; set; }
        public int? PreguntaTipoId { get; set; }

        public virtual PreguntaConfiguracion PreguntaConfiguracion { get; set; }
        public virtual PreguntaTipo PreguntaTipo { get; set; }
        public virtual PreguntaTipoValores PreguntaTipoValores { get; set; }
    }
}
