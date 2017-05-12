using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoCuatrimestre
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Cuatrimestre { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public TimeSpan HoraInscripcion { get; set; }
        public int UsuarioId { get; set; }
    }
}
