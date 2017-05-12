using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO
{
    public class DTOUsuarioTipo
    {
        public int usuarioTipoId { get; set; }
        public string descripcion { get; set; }
        public List<DTOTipoUsuarioSubMenu> TipoUsuarioSubmenu { get; set; }
    }
}
