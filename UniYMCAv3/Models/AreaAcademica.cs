using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AreaAcademica
    {
        public AreaAcademica()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int AreaAcademicaId { get; set; }
        public string Descripcion { get; set; }
        public bool SeMuestra { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
    }
}
