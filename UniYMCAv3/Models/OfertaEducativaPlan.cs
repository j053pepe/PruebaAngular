using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class OfertaEducativaPlan
    {
        public int OfertaEducativaPlanId { get; set; }
        public int OfertaEducativaTipoId { get; set; }
        public int PagoPlanId { get; set; }

        public virtual OfertaEducativaTipo OfertaEducativaTipo { get; set; }
        public virtual PagoPlan PagoPlan { get; set; }
    }
}
