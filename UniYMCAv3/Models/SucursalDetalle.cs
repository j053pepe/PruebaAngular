using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class SucursalDetalle
    {
        public int SucursalId { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string Colonia { get; set; }
        public string Cp { get; set; }
        public string Delegacion { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public string Telefono { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
