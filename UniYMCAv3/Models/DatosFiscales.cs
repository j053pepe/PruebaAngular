using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DatosFiscales
    {
        public int EmpresaId { get; set; }
        public string Rfc { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public int MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Observacion { get; set; }
        public bool EsEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
