using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class EstadoCivil
    {
        public EstadoCivil()
        {
            AlumnoDetalle = new HashSet<AlumnoDetalle>();
            AlumnoDetalleAlumno = new HashSet<AlumnoDetalleAlumno>();
            AlumnoDetalleCoordinador = new HashSet<AlumnoDetalleCoordinador>();
            DocenteDetalle = new HashSet<DocenteDetalle>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int EstadoCivilId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoDetalle> AlumnoDetalle { get; set; }
        public virtual ICollection<AlumnoDetalleAlumno> AlumnoDetalleAlumno { get; set; }
        public virtual ICollection<AlumnoDetalleCoordinador> AlumnoDetalleCoordinador { get; set; }
        public virtual ICollection<DocenteDetalle> DocenteDetalle { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
    }
}
