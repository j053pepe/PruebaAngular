using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioTipoPagoConcepto
    {
        public int UsuarioTipoId { get; set; }
        public int PagoConceptoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public TimeSpan HoraAsignacion { get; set; }
        public int UsuarioIdAsignacion { get; set; }

        public virtual Usuario UsuarioIdAsignacionNavigation { get; set; }
        public virtual UsuarioTipo UsuarioTipo { get; set; }
        public virtual PagoConcepto PagoConcepto { get; set; }
    }
}
