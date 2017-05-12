using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Menu
    {
        public Menu()
        {
            SubMenu = new HashSet<SubMenu>();
        }

        public int MenuId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<SubMenu> SubMenu { get; set; }
    }
}
