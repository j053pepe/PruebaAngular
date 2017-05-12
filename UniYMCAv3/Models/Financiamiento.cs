using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Financiamiento
    {
        public int FinanciamientoId { get; set; }
        public int AlumnoId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public decimal Porcentaje { get; set; }
        public int CuotaId { get; set; }
        public decimal Cuota { get; set; }
        public decimal? Importe { get; set; }
        public string Observacion { get; set; }
        public int EstatusId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual Cuota CuotaNavigation { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}
