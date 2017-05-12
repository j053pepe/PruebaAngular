using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoLayout
    {
        public int ReferenciaConfiguracionId { get; set; }
        public string Descripcion { get; set; }
        public int PosicionInicial { get; set; }
        public int PosicionFinal { get; set; }
        public string Banco { get; set; }
    }
}
