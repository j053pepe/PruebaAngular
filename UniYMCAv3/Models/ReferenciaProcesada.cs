using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ReferenciaProcesada
    {
        public ReferenciaProcesada()
        {
            AlumnoSaldoDetalle = new HashSet<AlumnoSaldoDetalle>();
            PagoParcial = new HashSet<PagoParcial>();
            ReferenciadoDetalle = new HashSet<ReferenciadoDetalle>();
        }

        public int ReferenciaProcesadaId { get; set; }
        public string ReferenciaId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Importe { get; set; }
        public decimal Restante { get; set; }
        public int AlumnoId { get; set; }
        public int ReferenciaTipoId { get; set; }
        public string Observaciones { get; set; }
        public bool SeGasto { get; set; }
        public bool EsIngles { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<AlumnoSaldoDetalle> AlumnoSaldoDetalle { get; set; }
        public virtual ICollection<PagoParcial> PagoParcial { get; set; }
        public virtual ICollection<ReferenciadoDetalle> ReferenciadoDetalle { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual ReferenciaTipo ReferenciaTipo { get; set; }
    }
}
