using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Caja
    {
        public Caja()
        {
            SucursalCaja = new HashSet<SucursalCaja>();
        }

        public int CajaId { get; set; }
        public string Descripcion { get; set; }
        public string Mac { get; set; }
        public int ReciboId { get; set; }

        public virtual ICollection<SucursalCaja> SucursalCaja { get; set; }
    }
}
