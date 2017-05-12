using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoInscritoDocumento
    {
        public int AlumnoInscritoDocumentoId { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int TipoDocumento { get; set; }
        public byte[] Archivo { get; set; }
        public int? UsuarioDocumento { get; set; }
        public DateTime? FechaDocumento { get; set; }
    }
}
