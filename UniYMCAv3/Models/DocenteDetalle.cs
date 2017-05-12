using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class DocenteDetalle
    {
        public int DocenteId { get; set; }
        public int GeneroId { get; set; }
        public int EstadoCivilId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Email { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoCasa { get; set; }

        public virtual Docente Docente { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
