using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoSaldoDetalle
    {
        public int ConsecutivoId { get; set; }
        public string ReferenciaId { get; set; }
        public int AlumnoId { get; set; }
        public int Rubro { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public TimeSpan HoraAplicacion { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoDespues { get; set; }
        public bool EsReferenciado { get; set; }
        public int? ReferenciaProcesadaId { get; set; }

        public virtual AlumnoSaldo Alumno { get; set; }
        public virtual ReferenciaProcesada ReferenciaProcesada { get; set; }
    }
}
