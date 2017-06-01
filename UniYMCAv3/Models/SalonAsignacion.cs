using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class SalonAsignacion
    {
        public int SalonAsignacionId { get; set; }
        public int? MateriaAperturaId { get; set; }
        public int? DiaId { get; set; }
        public int? HoraInicioId { get; set; }
        public int? HoraFinId { get; set; }
        public int? SalonId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public TimeSpan? HoraAsignacion { get; set; }
        public int? UsuarioId { get; set; }
    }
}
