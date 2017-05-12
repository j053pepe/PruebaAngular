using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class IdiomaGrupoAlumno
    {
        public int AlumnoId { get; set; }
        public int IdiomaGrupoId { get; set; }
        public int? OfertaEducativaId { get; set; }
        public string TipoCurso { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public TimeSpan? HoraAsignacion { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual IdiomaGrupo IdiomaGrupo { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
