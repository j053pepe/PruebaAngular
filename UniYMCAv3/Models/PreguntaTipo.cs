using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaTipo
    {
        public PreguntaTipo()
        {
            PreguntaCompuesta = new HashSet<PreguntaCompuesta>();
            PreguntaConfiguracion = new HashSet<PreguntaConfiguracion>();
            PreguntaTipoValores = new HashSet<PreguntaTipoValores>();
        }

        public int PreguntaTipoId { get; set; }
        public string Descripcion { get; set; }
        public int? ValorId { get; set; }

        public virtual ICollection<PreguntaCompuesta> PreguntaCompuesta { get; set; }
        public virtual ICollection<PreguntaConfiguracion> PreguntaConfiguracion { get; set; }
        public virtual ICollection<PreguntaTipoValores> PreguntaTipoValores { get; set; }
        public virtual PreguntaValor Valor { get; set; }
    }
}
