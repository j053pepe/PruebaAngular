using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoBitacora
    {
        public int AlumnoIdBitacora { get; set; }
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public string MatriculaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int EstatusId { get; set; }
        public int UsuarioIdBitacora { get; set; }
        public DateTime Fecha { get; set; }
    }
}
