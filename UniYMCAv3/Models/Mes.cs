using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Mes
    {
        public Mes()
        {
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            PolizaConsecutivo = new HashSet<PolizaConsecutivo>();
            Subperiodo = new HashSet<Subperiodo>();
        }

        public int MesId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<PolizaConsecutivo> PolizaConsecutivo { get; set; }
        public virtual ICollection<Subperiodo> Subperiodo { get; set; }
    }
}
