using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioSucursalCaja
    {
        public int UsuarioId { get; set; }
        public int SucursalCajaId { get; set; }

        public virtual SucursalCaja SucursalCaja { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
