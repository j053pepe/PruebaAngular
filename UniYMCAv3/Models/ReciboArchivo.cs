using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReciboArchivo
    {
        public int SucursalCajaId { get; set; }
        public int ReciboId { get; set; }
        public byte[] Archivo { get; set; }

        public virtual SucursalCaja SucursalCaja { get; set; }
        public virtual Recibo Recibo { get; set; }
    }
}
