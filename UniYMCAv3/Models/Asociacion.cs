using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Asociacion
    {
        public Asociacion()
        {
            PolizaConfiguracion = new HashSet<PolizaConfiguracion>();
            PolizaConsecutivo = new HashSet<PolizaConsecutivo>();
            PolizaCuadre = new HashSet<PolizaCuadre>();
            PolizaNumeracion = new HashSet<PolizaNumeracion>();
            ReferenciadoArchivoBitacora = new HashSet<ReferenciadoArchivoBitacora>();
        }

        public int AsociacionId { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
        public string Carpeta { get; set; }

        public virtual AsociacionDetalle AsociacionDetalle { get; set; }
        public virtual ICollection<PolizaConfiguracion> PolizaConfiguracion { get; set; }
        public virtual ICollection<PolizaConsecutivo> PolizaConsecutivo { get; set; }
        public virtual ICollection<PolizaCuadre> PolizaCuadre { get; set; }
        public virtual ICollection<PolizaNumeracion> PolizaNumeracion { get; set; }
        public virtual ICollection<ReferenciadoArchivoBitacora> ReferenciadoArchivoBitacora { get; set; }
    }
}
