using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class MedioDifusion
    {
        public MedioDifusion()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
        }

        public int MedioDifusionId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
    }
}
