using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoCancelacionSolicitud
    {
        public int SolicitudId { get; set; }
        public int? PagoId { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public TimeSpan? HoraSolicitud { get; set; }
        public string Comentario { get; set; }
        public int? UsuarioIdSolicitud { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public TimeSpan? HoraAplicacion { get; set; }
        public int? UsuarioIdAutoriza { get; set; }
        public int? EstatusId { get; set; }
    }
}
