using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class OfertaEducativaAntecedente
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public TimeSpan HoraInscripcion { get; set; }
        public int UsuarioId { get; set; }
        public int TurnoId { get; set; }
        public int PagoPlanId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int EstatusId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual PagoPlan PagoPlan { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
