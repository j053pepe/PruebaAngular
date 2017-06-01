using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Respuesta
    {
        public int RespuestaId { get; set; }
        public int? AlumnoId { get; set; }
        public int? PreguntaId { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public TimeSpan? HoraGeneracion { get; set; }
        public int? PreguntaTipoValoresId1 { get; set; }
        public int? PreguntaTipoValoresId2 { get; set; }
        public string Comentario { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Pregunta Pregunta { get; set; }
        public virtual PreguntaTipoValores PreguntaTipoValoresId1Navigation { get; set; }
        public virtual PreguntaTipoValores PreguntaTipoValoresId2Navigation { get; set; }
    }
}
