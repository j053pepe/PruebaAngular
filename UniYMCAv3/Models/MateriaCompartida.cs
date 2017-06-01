using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class MateriaCompartida
    {
        public int MateriaCompartidadId { get; set; }
        public int MateriaAperturaId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public DateTime? FechaGeneracion { get; set; }
        public TimeSpan? HoraGeneracion { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }
    }
}
