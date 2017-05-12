using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReclasificacionTipo
    {
        public ReclasificacionTipo()
        {
            Reclasificacion = new HashSet<Reclasificacion>();
        }

        public int ReclasificacionTipoId { get; set; }
        public string Descripcion { get; set; }
        public string CuentaBase { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<Reclasificacion> Reclasificacion { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}
