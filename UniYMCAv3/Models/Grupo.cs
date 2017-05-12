using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Grupo
    {
        public Grupo()
        {
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            GrupoComprobante = new HashSet<GrupoComprobante>();
        }

        public int GrupoId { get; set; }
        public int EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public int SucursalId { get; set; }
        public string SucursalDireccion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int NumeroPagos { get; set; }
        public int UsuarioId { get; set; }

        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<GrupoComprobante> GrupoComprobante { get; set; }
        public virtual GrupoDetalle GrupoDetalle { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
