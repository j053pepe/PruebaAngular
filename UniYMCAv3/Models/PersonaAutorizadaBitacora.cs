using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PersonaAutorizadaBitacora
    {
        public int PersonaAutorizadaBitacoraId { get; set; }
        public int PersonaAutorizadaId { get; set; }
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int ParentescoId { get; set; }
        public bool EsAutorizada { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
