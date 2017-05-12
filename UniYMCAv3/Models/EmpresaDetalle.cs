using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class EmpresaDetalle
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string EmailContacto { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public int MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Email { get; set; }
        public string Observacion { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
