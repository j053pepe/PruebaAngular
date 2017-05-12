using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ProspectoSeguimiento
    {
        public int ProspectoSeguimientoId { get; set; }
        public int ProspectoId { get; set; }
        public DateTime FechaComentario { get; set; }
        public string Comentario { get; set; }
        public int UsuarioId { get; set; }

        public virtual Prospecto Prospecto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
