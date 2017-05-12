using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Subperiodo
    {
        public Subperiodo()
        {
            Pago = new HashSet<Pago>();
        }

        public int SubperiodoId { get; set; }
        public int PeriodoId { get; set; }
        public int MesId { get; set; }

        public virtual ICollection<Pago> Pago { get; set; }
        public virtual Mes Mes { get; set; }
    }
}
