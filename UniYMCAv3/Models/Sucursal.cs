using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            OfertaEducativa = new HashSet<OfertaEducativa>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
            SucursalAnuncio = new HashSet<SucursalAnuncio>();
            SucursalCaja = new HashSet<SucursalCaja>();
        }

        public int SucursalId { get; set; }
        public string DescripcionId { get; set; }
        public string Serie { get; set; }
        public bool EsSucursal { get; set; }
        public string ClaveIngreso { get; set; }
        public string ClaveOtros { get; set; }
        public string ClaveDescuentos { get; set; }

        public virtual ICollection<OfertaEducativa> OfertaEducativa { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
        public virtual ICollection<SucursalAnuncio> SucursalAnuncio { get; set; }
        public virtual ICollection<SucursalCaja> SucursalCaja { get; set; }
        public virtual SucursalDetalle SucursalDetalle { get; set; }
    }
}
