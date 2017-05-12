using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class BancoTerminal
    {
        public BancoTerminal()
        {
            ReciboMsi = new HashSet<ReciboMsi>();
        }

        public int BancoTerminalId { get; set; }
        public string Descripcion { get; set; }
        public bool TieneMsi { get; set; }
        public string CuentaContable { get; set; }
        public int PagoMetodoId { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<ReciboMsi> ReciboMsi { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual PagoMetodo PagoMetodo { get; set; }
    }
}
