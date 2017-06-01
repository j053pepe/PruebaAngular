using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoMovimiento
    {
        public int AlumnoMovimientoId { get; set; }
        public int? AlumnoId { get; set; }
        public int? OfertaEducativaId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public int? TipoMovimientoId { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }

        public virtual AlumnoMovimientoBaja AlumnoMovimientoBaja { get; set; }
        public virtual AlumnoMovimientoCarrera AlumnoMovimientoCarrera { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual TipoMovimiento TipoMovimiento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
