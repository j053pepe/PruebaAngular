using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PolizaNumeracion
    {
        public int AsociacionId { get; set; }
        public int PolizaTipoId { get; set; }
        public int PolizaSubtipoId { get; set; }
        public int FolioInicial { get; set; }
        public int FolioFinal { get; set; }
        public string Descripcion { get; set; }
        public string Ruta { get; set; }
        public string Email { get; set; }

        public virtual Asociacion Asociacion { get; set; }
        public virtual PolizaSubtipo PolizaSubtipo { get; set; }
        public virtual PolizaTipo PolizaTipo { get; set; }
    }
}
