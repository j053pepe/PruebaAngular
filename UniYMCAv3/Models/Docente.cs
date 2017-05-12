using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Docente
    {
        public int DocenteId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioId { get; set; }

        public virtual DocenteDetalle DocenteDetalle { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
