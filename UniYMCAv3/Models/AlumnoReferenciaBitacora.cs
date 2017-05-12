using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoReferenciaBitacora
    {
        public int BitacoraId { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int PagoConceptoId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public int PagoId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Pago Pago { get; set; }
        public virtual PagoConcepto PagoConcepto { get; set; }
    }
}
