using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class EntidadFederativa
    {
        public EntidadFederativa()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            AlumnoDetalleEntidadFederativa = new HashSet<AlumnoDetalle>();
            AlumnoDetalleEntidadNacimiento = new HashSet<AlumnoDetalle>();
            AlumnoDetalleAlumno = new HashSet<AlumnoDetalleAlumno>();
            AlumnoDetalleCoordinador = new HashSet<AlumnoDetalleCoordinador>();
            Municipio = new HashSet<Municipio>();
            ProspectoDetalleEntidadFederativa = new HashSet<ProspectoDetalle>();
            ProspectoDetallePrepaEntidad = new HashSet<ProspectoDetalle>();
            ProspectoDetalleUniversidadEntidad = new HashSet<ProspectoDetalle>();
        }

        public int EntidadFederativaId { get; set; }
        public string Clave { get; set; }
        public bool SeMuestra { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<AlumnoDetalle> AlumnoDetalleEntidadFederativa { get; set; }
        public virtual ICollection<AlumnoDetalle> AlumnoDetalleEntidadNacimiento { get; set; }
        public virtual ICollection<AlumnoDetalleAlumno> AlumnoDetalleAlumno { get; set; }
        public virtual ICollection<AlumnoDetalleCoordinador> AlumnoDetalleCoordinador { get; set; }
        public virtual ICollection<Municipio> Municipio { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalleEntidadFederativa { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetallePrepaEntidad { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalleUniversidadEntidad { get; set; }
    }
}
