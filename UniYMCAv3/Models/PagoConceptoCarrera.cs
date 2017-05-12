using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoConceptoCarrera
    {
        public int PagoConceptoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public string CuentaContable { get; set; }
    }
}
