using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DocentePublicacion
    {
        public int DocenteId { get; set; }
        public int? PublicacionTipoId { get; set; }
        public string Titulo { get; set; }
        public string TituloPublicacion { get; set; }
        public string Editorial { get; set; }
        public string NoVolumen { get; set; }
        public string NoPagina { get; set; }
        public int? PaisId { get; set; }
        public int? EntidadFederativaId { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public TimeSpan? HoraRegistro { get; set; }
        public int? UsuarioId { get; set; }
    }
}
