using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoDescuentoBitacora
    {
        public int AlumnoDescuentoId { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int DescuentoId { get; set; }
        public int PagoConceptoId { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public bool EsSep { get; set; }
        public bool EsComite { get; set; }
        public bool EsDeportiva { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public int EstatusId { get; set; }
    }
}
