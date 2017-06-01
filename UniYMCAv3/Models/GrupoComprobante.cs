using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class GrupoComprobante
    {
        public int GrupoComprobanteId { get; set; }
        public int GrupoId { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }
        public int UsuarioId { get; set; }

        public virtual GrupoComprobanteDocumento GrupoComprobanteDocumento { get; set; }
        public virtual Grupo1 Grupo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
