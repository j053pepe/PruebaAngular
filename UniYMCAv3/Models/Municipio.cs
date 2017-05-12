using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            AlumnoDetalle = new HashSet<AlumnoDetalle>();
            AlumnoDetalleAlumno = new HashSet<AlumnoDetalleAlumno>();
            AlumnoDetalleCoordinador = new HashSet<AlumnoDetalleCoordinador>();
            DatosFiscales = new HashSet<DatosFiscales>();
            EmpresaDetalle = new HashSet<EmpresaDetalle>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int MunicipioId { get; set; }
        public int EntidadFederativaId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoDetalle> AlumnoDetalle { get; set; }
        public virtual ICollection<AlumnoDetalleAlumno> AlumnoDetalleAlumno { get; set; }
        public virtual ICollection<AlumnoDetalleCoordinador> AlumnoDetalleCoordinador { get; set; }
        public virtual ICollection<DatosFiscales> DatosFiscales { get; set; }
        public virtual ICollection<EmpresaDetalle> EmpresaDetalle { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
        public virtual EntidadFederativa EntidadFederativa { get; set; }
    }
}
