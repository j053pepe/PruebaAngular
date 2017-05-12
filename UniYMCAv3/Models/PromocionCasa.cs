using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PromocionCasa
    {
        public int AlumnoId { get; set; }
        public int? OfertaEducativaId { get; set; }
        public int? AlumnoIdProspecto { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int? SubPeriodoId { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public TimeSpan? HoraGeneracion { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public TimeSpan? HoraAplicacion { get; set; }
        public int? UsuarioId { get; set; }
        public int? PagoId { get; set; }
        public int? EstatusId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Alumno AlumnoIdProspectoNavigation { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Periodo Periodo { get; set; }
    }
}
