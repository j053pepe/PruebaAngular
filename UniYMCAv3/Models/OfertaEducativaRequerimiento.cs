using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class OfertaEducativaRequerimiento
    {
        public int OfertaEducativaId { get; set; }
        public int NivelAcademicoId { get; set; }
        public int NoAsignaturas { get; set; }
        public decimal Creditos { get; set; }

        public virtual NivelAcademico NivelAcademico { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
