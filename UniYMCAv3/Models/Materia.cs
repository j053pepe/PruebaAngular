using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Materia
    {
        public int MateriaId { get; set; }
        public string Descripcion { get; set; }
        public int? OfertaEducativaId { get; set; }
        public string Clave { get; set; }
        public decimal? Creditos { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public TimeSpan? HoraRegistro { get; set; }
        public int? UsuarioId { get; set; }
    }
}
