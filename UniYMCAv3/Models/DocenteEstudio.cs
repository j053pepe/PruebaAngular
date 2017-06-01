using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DocenteEstudio
    {
        public int DocenteId { get; set; }
        public string Descripcion { get; set; }
        public int? OfertaEducativaTipoId { get; set; }
        public string NoCedula { get; set; }
        public DateTime? FechaExpedicion { get; set; }
        public string Institucion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public TimeSpan? HoraRegistro { get; set; }
        public int? UsuarioId { get; set; }
        public int? EstatusId { get; set; }
    }
}
