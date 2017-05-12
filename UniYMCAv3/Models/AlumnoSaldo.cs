using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoSaldo
    {
        public AlumnoSaldo()
        {
            AlumnoSaldoDetalle = new HashSet<AlumnoSaldoDetalle>();
            AlumnoSaldoGasto = new HashSet<AlumnoSaldoGasto>();
        }

        public int AlumnoId { get; set; }
        public decimal Saldo { get; set; }

        public virtual ICollection<AlumnoSaldoDetalle> AlumnoSaldoDetalle { get; set; }
        public virtual ICollection<AlumnoSaldoGasto> AlumnoSaldoGasto { get; set; }
        public virtual Alumno Alumno { get; set; }
    }
}
