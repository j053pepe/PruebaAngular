using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DocenteDetalle
    {
        public int DocenteId { get; set; }
        public DateTime? FechaNaciminto { get; set; }
        public string Curp { get; set; }
        public string Rfc { get; set; }
        public string Nss { get; set; }
        public int? GeneroId { get; set; }
        public int? EstadoCivilId { get; set; }
        public int? PaisId { get; set; }
        public int? EntidadNacimientoId { get; set; }
        public int? EntidadFederativaId { get; set; }
        public int? MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoOficina { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
