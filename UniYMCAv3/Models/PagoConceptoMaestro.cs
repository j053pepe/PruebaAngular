using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoConceptoMaestro
    {
        public int PagoConceptoId { get; set; }
        public string Descripcion { get; set; }
        public string CuentaContable { get; set; }
        public bool EsCobrable { get; set; }
        public bool EsVisible { get; set; }
        public int EstatusId { get; set; }

        public virtual Estatus Estatus { get; set; }
    }
}
