using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class GrupoBitacora
    {
        public int GrupoId { get; set; }
        public int EmpresaId { get; set; }
        public string Descripcion { get; set; }
        public int SucursalId { get; set; }
        public string SucursalDireccion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int NumeroPagos { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public TimeSpan HoraModificacion { get; set; }
        public int UsuarioIdModificacion { get; set; }
    }
}
