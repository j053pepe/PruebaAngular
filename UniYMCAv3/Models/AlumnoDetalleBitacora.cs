using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoDetalleBitacora
    {
        public int AlumnoDetalleBitacoraId { get; set; }
        public int AlumnoId { get; set; }
        public int GeneroId { get; set; }
        public int EstadoCivilId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public int? EntidadNacimientoId { get; set; }
        public int MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoOficina { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int ProspectoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
