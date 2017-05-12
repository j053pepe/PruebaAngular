using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Pago
    {
        public Pago()
        {
            AlumnoReferenciaBitacora = new HashSet<AlumnoReferenciaBitacora>();
            PagoDescuento = new HashSet<PagoDescuento>();
            PagoPagare = new HashSet<PagoPagare>();
            PagoParcial = new HashSet<PagoParcial>();
            PagoRecargoPago = new HashSet<PagoRecargo>();
            PagoRecargoPagoIdRecargoNavigation = new HashSet<PagoRecargo>();
            PolizaAjuste = new HashSet<PolizaAjuste>();
            PromocionCasa = new HashSet<PromocionCasa>();
        }

        public int PagoId { get; set; }
        public string ReferenciaId { get; set; }
        public int AlumnoId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int SubperiodoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public int CuotaId { get; set; }
        public decimal Cuota { get; set; }
        public decimal Promesa { get; set; }
        public decimal Restante { get; set; }
        public int EstatusId { get; set; }
        public int UsuarioId { get; set; }
        public int UsuarioTipoId { get; set; }
        public bool EsEmpresa { get; set; }
        public bool EsAnticipado { get; set; }
        public int PeriodoAnticipadoId { get; set; }

        public virtual ICollection<AlumnoReferenciaBitacora> AlumnoReferenciaBitacora { get; set; }
        public virtual PagoCancelacion PagoCancelacion { get; set; }
        public virtual PagoDescripcion PagoDescripcion { get; set; }
        public virtual ICollection<PagoDescuento> PagoDescuento { get; set; }
        public virtual ICollection<PagoPagare> PagoPagare { get; set; }
        public virtual ICollection<PagoParcial> PagoParcial { get; set; }
        public virtual ICollection<PagoRecargo> PagoRecargoPago { get; set; }
        public virtual ICollection<PagoRecargo> PagoRecargoPagoIdRecargoNavigation { get; set; }
        public virtual ICollection<PolizaAjuste> PolizaAjuste { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasa { get; set; }
        public virtual ReferenciadoCabecero ReferenciadoCabecero { get; set; }
        public virtual ReferenciadoCabeceroBitacora ReferenciadoCabeceroBitacora { get; set; }
        public virtual ReferenciaGeneradaBitacora ReferenciaGeneradaBitacora { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Cuota CuotaNavigation { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Subperiodo Subperiodo { get; set; }
    }
}
