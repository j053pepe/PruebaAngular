using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Periodo
    {
        public Periodo()
        {
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            AlumnoRevision = new HashSet<AlumnoRevision>();
            Cuota = new HashSet<Cuota>();
            CuotaIncremento = new HashSet<CuotaIncremento>();
            Matricula = new HashSet<Matricula>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            Pago = new HashSet<Pago>();
            PeriodoAnticipado = new HashSet<PeriodoAnticipado>();
            PromocionCasa = new HashSet<PromocionCasa>();
        }

        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Descripcion { get; set; }
        public int Meses { get; set; }

        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<AlumnoRevision> AlumnoRevision { get; set; }
        public virtual ICollection<Cuota> Cuota { get; set; }
        public virtual ICollection<CuotaIncremento> CuotaIncremento { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<PeriodoAnticipado> PeriodoAnticipado { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasa { get; set; }
    }
}
