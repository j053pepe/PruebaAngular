using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoInscritoDetalleBitacora
    {
        public int IdBitacora { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public bool NuevoIngreso { get; set; }
        public int EstatusId { get; set; }
        public bool CargosIniciales { get; set; }
        public int UsuarioCargosIniciales { get; set; }
        public DateTime FechaCargosIniciales { get; set; }
        public bool Inscripcion { get; set; }
        public int UsuarioInscripcion { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool BecaAcademica { get; set; }
        public decimal Porcentaje { get; set; }
        public int UsuarioBecaAcademica { get; set; }
        public DateTime FechaBecaAcademica { get; set; }
        public bool BecaSep { get; set; }
        public int UsuarioBecaSep { get; set; }
        public DateTime FechaBecaSep { get; set; }
        public bool BecaComite { get; set; }
        public int UsuarioBecaComite { get; set; }
        public DateTime FechaBecaComite { get; set; }
        public bool BecaDeportiva { get; set; }
        public decimal PorcentajeBecaDeportiva { get; set; }
        public int UsuarioBecaDeportiva { get; set; }
        public DateTime FechaBecaDeportiva { get; set; }
        public bool Pagare { get; set; }
        public int UsuarioPagare { get; set; }
        public DateTime FechaPagare { get; set; }
        public bool AdeudoBiblioteca { get; set; }
        public int UsuarioAdeudoBiblioteca { get; set; }
        public DateTime FechaAdeudoBiblioteca { get; set; }
        public bool Financiamiento { get; set; }
        public int UsuarioFinanciamiento { get; set; }
        public DateTime FechaFinanciamiento { get; set; }
        public int UsuarioBitacora { get; set; }
        public DateTime FechaBitacota { get; set; }
    }
}
