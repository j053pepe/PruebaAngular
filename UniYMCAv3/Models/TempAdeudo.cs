using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class TempAdeudo
    {
        public int AlumnoId { get; set; }
        public decimal Adeudo { get; set; }
        public int Tipo { get; set; }
        public int OfertaEducativaId { get; set; }
    }
}
