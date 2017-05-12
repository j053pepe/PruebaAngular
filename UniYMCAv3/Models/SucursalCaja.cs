using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class SucursalCaja
    {
        public SucursalCaja()
        {
            CajaConfiguracion = new HashSet<CajaConfiguracion>();
            Recibo = new HashSet<Recibo>();
            ReciboArchivo = new HashSet<ReciboArchivo>();
            UsuarioSucursalCaja = new HashSet<UsuarioSucursalCaja>();
        }

        public int SucursalCajaId { get; set; }
        public int SucursalId { get; set; }
        public int CajaId { get; set; }

        public virtual ICollection<CajaConfiguracion> CajaConfiguracion { get; set; }
        public virtual ICollection<Recibo> Recibo { get; set; }
        public virtual ICollection<ReciboArchivo> ReciboArchivo { get; set; }
        public virtual ICollection<UsuarioSucursalCaja> UsuarioSucursalCaja { get; set; }
        public virtual Caja Caja { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
