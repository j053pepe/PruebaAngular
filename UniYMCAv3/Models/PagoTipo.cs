using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoTipo
    {
        public PagoTipo()
        {
            PagoParcial = new HashSet<PagoParcial>();
        }

        public int PagoTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PagoParcial> PagoParcial { get; set; }
    }
}
