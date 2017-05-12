using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class SucursalAnuncio
    {
        public int AnuncioId { get; set; }
        public int SucursalId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaGeneracion { get; set; }

        public virtual Sucursal Sucursal { get; set; }
    }
}
