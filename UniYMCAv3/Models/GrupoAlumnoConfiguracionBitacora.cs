using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class GrupoAlumnoConfiguracionBitacora
    {
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int? GrupoId { get; set; }
        public decimal CuotaColegiatura { get; set; }
        public decimal CuotaInscripcion { get; set; }
        public bool EsCuotaCongelada { get; set; }
        public bool EsInscripcionCongelada { get; set; }
        public bool EsEspecial { get; set; }
        public int UsuarioId { get; set; }
        public int? PagoPlanId { get; set; }
        public int? NumeroPagos { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }

        public virtual PagoPlan PagoPlan { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
