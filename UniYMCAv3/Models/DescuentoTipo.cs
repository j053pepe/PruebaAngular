using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DescuentoTipo
    {
        public DescuentoTipo()
        {
            Descuento = new HashSet<Descuento>();
        }

        public int DescuentoTipoId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Descuento> Descuento { get; set; }
    }
}
