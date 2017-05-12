using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Pais
    {
        public Pais()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            AlumnoDetalle = new HashSet<AlumnoDetalle>();
            DatosFiscales = new HashSet<DatosFiscales>();
            EmpresaDetalle = new HashSet<EmpresaDetalle>();
            ProspectoDetallePais = new HashSet<ProspectoDetalle>();
            ProspectoDetallePrepaPais = new HashSet<ProspectoDetalle>();
            ProspectoDetalleUniversidadPais = new HashSet<ProspectoDetalle>();
            SucursalDetalle = new HashSet<SucursalDetalle>();
        }

        public int PaisId { get; set; }
        public string Iso { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<AlumnoDetalle> AlumnoDetalle { get; set; }
        public virtual ICollection<DatosFiscales> DatosFiscales { get; set; }
        public virtual ICollection<EmpresaDetalle> EmpresaDetalle { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetallePais { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetallePrepaPais { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalleUniversidadPais { get; set; }
        public virtual ICollection<SucursalDetalle> SucursalDetalle { get; set; }
    }
}
