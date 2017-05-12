using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class LenguasRelacion
    {
        public int CuotaId { get; set; }
        public string Descripcion { get; set; }
        public int DiaInicial { get; set; }
        public int DiaFinal { get; set; }

        public virtual Cuota Cuota { get; set; }
    }
}
