using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AntecedenteTipo
    {
        public AntecedenteTipo()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            OfertaEducativaTipo = new HashSet<OfertaEducativaTipo>();
        }

        public int AntecedenteTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<OfertaEducativaTipo> OfertaEducativaTipo { get; set; }
    }
}
