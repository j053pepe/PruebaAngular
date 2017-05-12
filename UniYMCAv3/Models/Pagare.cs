using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Pagare
    {
        public Pagare()
        {
            PagoPagare = new HashSet<PagoPagare>();
        }

        public int PagareId { get; set; }
        public int AlumnoId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public decimal Interes { get; set; }
        public string Observacion { get; set; }
        public int UsuarioId { get; set; }
        public int EstatusId { get; set; }

        public virtual PagareDocumento PagareDocumento { get; set; }
        public virtual ICollection<PagoPagare> PagoPagare { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
