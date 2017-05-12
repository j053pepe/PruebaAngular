using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioImagenDetalle
    {
        public int UsuarioId { get; set; }
        public string Extension { get; set; }
        public DateTime FechaCarga { get; set; }
        public TimeSpan HoraCarga { get; set; }
        public int UsuarioIdCarga { get; set; }

        public virtual UsuarioImagen Usuario { get; set; }
    }
}
