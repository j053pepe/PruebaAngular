using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Prospecto
    {
        public Prospecto()
        {
            ProspectoSeguimiento = new HashSet<ProspectoSeguimiento>();
        }

        public int ProspectoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }

        public virtual ProspectoDetalle ProspectoDetalle { get; set; }
        public virtual ICollection<ProspectoSeguimiento> ProspectoSeguimiento { get; set; }
    }
}
