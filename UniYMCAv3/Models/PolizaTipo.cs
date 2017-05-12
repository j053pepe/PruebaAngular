using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaTipo
    {
        public PolizaTipo()
        {
            PolizaCabeceroLayout = new HashSet<PolizaCabeceroLayout>();
            PolizaConfiguracion = new HashSet<PolizaConfiguracion>();
            PolizaConsecutivo = new HashSet<PolizaConsecutivo>();
            PolizaCuadre = new HashSet<PolizaCuadre>();
            PolizaDetalleLayout = new HashSet<PolizaDetalleLayout>();
            PolizaNumeracion = new HashSet<PolizaNumeracion>();
            ReferenciadoArchivoBitacora = new HashSet<ReferenciadoArchivoBitacora>();
        }

        public int PolizaTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PolizaCabeceroLayout> PolizaCabeceroLayout { get; set; }
        public virtual ICollection<PolizaConfiguracion> PolizaConfiguracion { get; set; }
        public virtual ICollection<PolizaConsecutivo> PolizaConsecutivo { get; set; }
        public virtual ICollection<PolizaCuadre> PolizaCuadre { get; set; }
        public virtual ICollection<PolizaDetalleLayout> PolizaDetalleLayout { get; set; }
        public virtual ICollection<PolizaNumeracion> PolizaNumeracion { get; set; }
        public virtual ICollection<ReferenciadoArchivoBitacora> ReferenciadoArchivoBitacora { get; set; }
    }
}
