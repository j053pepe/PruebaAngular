using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoInscritoBecaDocumento
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public bool EsComite { get; set; }
        public byte[] ArchivoBeca { get; set; }
        public byte[] ArchivoComite { get; set; }
    }
}
