using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class TipoMovimiento
    {
        public TipoMovimiento()
        {
            AlumnoMovimiento = new HashSet<AlumnoMovimiento>();
        }

        public int TipoMovimientoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoMovimiento> AlumnoMovimiento { get; set; }
    }
}
