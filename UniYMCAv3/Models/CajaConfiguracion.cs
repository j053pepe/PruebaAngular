using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class CajaConfiguracion
    {
        public int ConfiguracionId { get; set; }
        public string ImpresoraRecibo { get; set; }
        public string ImpresoraReporteria { get; set; }
        public int SucursalCajaId { get; set; }

        public virtual SucursalCaja SucursalCaja { get; set; }
    }
}
