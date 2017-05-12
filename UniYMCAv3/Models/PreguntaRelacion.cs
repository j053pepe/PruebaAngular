using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PreguntaRelacion
    {
        public PreguntaRelacion()
        {
            Pregunta = new HashSet<Pregunta>();
        }

        public int PreguntaRelacionId { get; set; }
        public string Descripcion { get; set; }
        public int? PreguntaTipoId1 { get; set; }
        public bool? EsCompuesta { get; set; }
        public int? PreguntaTipoId2 { get; set; }

        public virtual ICollection<Pregunta> Pregunta { get; set; }
    }
}
