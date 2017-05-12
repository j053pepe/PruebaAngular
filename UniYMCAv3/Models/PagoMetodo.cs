using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoMetodo
    {
        public PagoMetodo()
        {
            BancoTerminal = new HashSet<BancoTerminal>();
            PagoDetalle = new HashSet<PagoDetalle>();
        }

        public int PagoMetodoId { get; set; }
        public string Descripcion { get; set; }
        public string CuentaContable { get; set; }
        public decimal Comision { get; set; }
        public bool EsVisible { get; set; }
        public bool TieneTerminal { get; set; }

        public virtual ICollection<BancoTerminal> BancoTerminal { get; set; }
        public virtual ICollection<PagoDetalle> PagoDetalle { get; set; }
    }
}
