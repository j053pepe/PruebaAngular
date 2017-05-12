using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UsuarioDetalle
    {
        public int UsuarioId { get; set; }
        public int GeneroId { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
