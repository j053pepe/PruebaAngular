using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class MateriaApertura
    {
        public int MateriaAperturaId { get; set; }
        public int? MateriaId { get; set; }
        public int? MateriaTipoId { get; set; }
        public decimal? Duracion { get; set; }
        public int? NoAlumnos { get; set; }
        public int? GrupoId { get; set; }
        public int? TurnoId { get; set; }
        public int? DocenteId { get; set; }
        public int? Anio { get; set; }
        public int? PeriodoId { get; set; }
        public bool? EsCompartida { get; set; }
        public DateTime? FechaApertura { get; set; }
        public TimeSpan? HoraApertura { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }
    }
}
