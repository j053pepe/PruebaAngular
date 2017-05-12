using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoSaldoGasto
    {
        public int ConsecutivoId { get; set; }
        public int PagoId { get; set; }
        public int AlumnoId { get; set; }
        public DateTime FechaGasto { get; set; }
        public TimeSpan HoraGasto { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoDespues { get; set; }
        public decimal Importe { get; set; }

        public virtual AlumnoSaldo Alumno { get; set; }
    }
}
