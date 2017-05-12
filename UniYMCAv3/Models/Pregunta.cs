using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Respuesta = new HashSet<Respuesta>();
        }

        public int PreguntaId { get; set; }
        public string Descripcion { get; set; }
        public string SubPregunta { get; set; }
        public int? PreguntaRelacionId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }

        public virtual ICollection<Respuesta> Respuesta { get; set; }
        public virtual PreguntaRelacion PreguntaRelacion { get; set; }
        public virtual PreguntaTipo PreguntaRelacionNavigation { get; set; }
    }
}
