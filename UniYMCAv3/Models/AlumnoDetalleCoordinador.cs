using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoDetalleCoordinador
    {
        public int AlumnoId { get; set; }
        public int EstadoCivilId { get; set; }
        public int EntidadFederativaId { get; set; }
        public int MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string TelefonoCasa { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public virtual EntidadFederativa EntidadFederativa { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
