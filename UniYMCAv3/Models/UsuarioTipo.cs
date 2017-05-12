using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioTipo
    {
        public UsuarioTipo()
        {
            TipoUsuarioSubmenu = new HashSet<TipoUsuarioSubmenu>();
            Usuario = new HashSet<Usuario>();
            UsuarioTipoPagoConcepto = new HashSet<UsuarioTipoPagoConcepto>();
        }

        public int UsuarioTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TipoUsuarioSubmenu> TipoUsuarioSubmenu { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<UsuarioTipoPagoConcepto> UsuarioTipoPagoConcepto { get; set; }
    }
}
