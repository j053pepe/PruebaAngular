using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class BajaMotivo
    {
        public BajaMotivo()
        {
            AlumnoMovimientoBaja = new HashSet<AlumnoMovimientoBaja>();
        }

        public int BajaMotivoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoMovimientoBaja> AlumnoMovimientoBaja { get; set; }
    }
}
