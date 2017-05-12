using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class IdiomaGrupo
    {
        public IdiomaGrupo()
        {
            IdiomaGrupoAlumno = new HashSet<IdiomaGrupoAlumno>();
        }

        public int IdiomaGrupoId { get; set; }
        public string Descripcion { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public TimeSpan? HoraRegistro { get; set; }
        public int? UsuarioId { get; set; }

        public virtual ICollection<IdiomaGrupoAlumno> IdiomaGrupoAlumno { get; set; }
    }
}
