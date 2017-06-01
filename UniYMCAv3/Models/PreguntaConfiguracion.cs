using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaConfiguracion
    {
        public PreguntaConfiguracion()
        {
            Pregunta = new HashSet<Pregunta>();
        }

        public int PreguntaConfiguracionId { get; set; }
        public string Descripcion { get; set; }
        public int? PreguntaTipoId { get; set; }
        public bool? EsCompuesta { get; set; }

        public virtual ICollection<Pregunta> Pregunta { get; set; }
        public virtual PreguntaCompuesta PreguntaConfiguracionNavigation { get; set; }
        public virtual PreguntaTipo PreguntaTipo { get; set; }
    }
}
