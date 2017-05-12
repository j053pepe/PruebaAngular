using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class UniversidadValidacion
    {
        public int UsuarioId { get; set; }
        public int MembresiaId { get; set; }
        public int NumeroFamiliar { get; set; }
        public int UsuarioTipoId { get; set; }
        public int CategoriaId { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFinal { get; set; }
        public DateTime FechaPago { get; set; }
        public int EstatusId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Inscrito { get; set; }
        public int OfertaEducativaId { get; set; }
        public int RequiereDeportivo { get; set; }
        public int Inscripcion { get; set; }
        public int Colegiatura { get; set; }
        public int Materias { get; set; }
        public int Asesorias { get; set; }
        public int ExamenMedico { get; set; }
        public decimal Adeudo { get; set; }
        public bool Nocturno { get; set; }

        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
