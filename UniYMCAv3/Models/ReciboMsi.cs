using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReciboMsi
    {
        public int ReciboId { get; set; }
        public int SucursalCajaId { get; set; }
        public int BancoTerminalId { get; set; }
        public int MesId { get; set; }
        public int Msi { get; set; }

        public virtual BancoTerminal BancoTerminal { get; set; }
        public virtual Recibo Recibo { get; set; }
    }
}
