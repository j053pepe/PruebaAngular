using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciadoArchivoBitacora
    {
        public int AsociacionId { get; set; }
        public int PolizaTipoId { get; set; }
        public int PolizaSubtipoId { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime FechaArchivo { get; set; }
        public DateTime FechaProcesado { get; set; }
        public TimeSpan HoraProcesado { get; set; }
        public int NoMovimientos { get; set; }
        public bool GeneroPoliza { get; set; }

        public virtual Asociacion Asociacion { get; set; }
        public virtual PolizaSubtipo PolizaSubtipo { get; set; }
        public virtual PolizaTipo PolizaTipo { get; set; }
    }
}
