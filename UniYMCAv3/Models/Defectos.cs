using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Defectos
    {
        public int DefectoId { get; set; }
        public DateTime? FechaDefecto { get; set; }
        public int? AlumnoId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public string Descripcion { get; set; }
        public int? UsuarioidReporto { get; set; }
        public int? UsuarioidResolvio { get; set; }
        public string DescripcionSolucion { get; set; }
    }
}
