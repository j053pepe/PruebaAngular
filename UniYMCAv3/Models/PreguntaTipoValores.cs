using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaTipoValores
    {
        public PreguntaTipoValores()
        {
            PreguntaCompuesta = new HashSet<PreguntaCompuesta>();
            RespuestaPreguntaTipoValoresId1Navigation = new HashSet<Respuesta>();
            RespuestaPreguntaTipoValoresId2Navigation = new HashSet<Respuesta>();
        }

        public int PreguntaTipoValoresId { get; set; }
        public int? PreguntaTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PreguntaCompuesta> PreguntaCompuesta { get; set; }
        public virtual ICollection<Respuesta> RespuestaPreguntaTipoValoresId1Navigation { get; set; }
        public virtual ICollection<Respuesta> RespuestaPreguntaTipoValoresId2Navigation { get; set; }
        public virtual PreguntaTipo PreguntaTipo { get; set; }
    }
}
