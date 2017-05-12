using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Reclasificacion
    {
        public int ReclasificacionId { get; set; }
        public int PagoParcialId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaReclasificacion { get; set; }
        public TimeSpan HoraReclasificacion { get; set; }
        public decimal Importe { get; set; }
        public int ReclasificacionTipoId { get; set; }

        public virtual PagoParcial PagoParcial { get; set; }
        public virtual ReclasificacionTipo ReclasificacionTipo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
