using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagareDocumento
    {
        public int PagareId { get; set; }
        public byte[] PagareDocumento1 { get; set; }

        public virtual Pagare Pagare { get; set; }
    }
}
