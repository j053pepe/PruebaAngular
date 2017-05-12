using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Asignatura
    {
        public int OfertaEducativaId { get; set; }
        public string AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int NivelAcademicoId { get; set; }
        public decimal Creditos { get; set; }
        public string AsignaturaSeriacionId { get; set; }
        public int EstatusId { get; set; }

        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
