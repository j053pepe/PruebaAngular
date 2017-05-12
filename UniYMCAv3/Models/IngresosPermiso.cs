using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class IngresosPermiso
    {
        public IngresosPermiso()
        {
            UsuarioPermiso = new HashSet<UsuarioPermiso>();
        }

        public int IngresosId { get; set; }
        public string Control { get; set; }
        public string Descripcion { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<UsuarioPermiso> UsuarioPermiso { get; set; }
    }
}
