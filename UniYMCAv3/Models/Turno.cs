using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Turno
    {
        public Turno()
        {
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int TurnoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
    }
}
