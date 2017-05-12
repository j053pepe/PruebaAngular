using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ProspectoBitacora
    {
        public int ProspectoBitacoraId { get; set; }
        public int ProspectoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
