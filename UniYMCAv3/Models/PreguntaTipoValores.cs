using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaTipoValores
    {
        public int PreguntaTipoValoresId { get; set; }
        public int? PreguntaTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual PreguntaTipo PreguntaTipo { get; set; }
    }
}
