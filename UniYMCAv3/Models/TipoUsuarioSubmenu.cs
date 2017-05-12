using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class TipoUsuarioSubmenu
    {
        public int TipoUsuarioSubmenuId { get; set; }
        public int SubmenuId { get; set; }
        public int UsuarioTipoId { get; set; }

        public virtual SubMenu Submenu { get; set; }
        public virtual UsuarioTipo UsuarioTipo { get; set; }
    }
}
