using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class SubMenu
    {
        public SubMenu()
        {
            TipoUsuarioSubmenu = new HashSet<TipoUsuarioSubmenu>();
        }

        public int SubmenuId { get; set; }
        public int MenuId { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<TipoUsuarioSubmenu> TipoUsuarioSubmenu { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
