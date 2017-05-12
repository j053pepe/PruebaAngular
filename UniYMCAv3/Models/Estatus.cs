using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Estatus
    {
        public Estatus()
        {
            Alumno = new HashSet<Alumno>();
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoDescuentoPendiente = new HashSet<AlumnoDescuentoPendiente>();
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoMovimiento = new HashSet<AlumnoMovimiento>();
            AlumnoPasswordRecovery = new HashSet<AlumnoPasswordRecovery>();
            Asignatura = new HashSet<Asignatura>();
            BancoTerminal = new HashSet<BancoTerminal>();
            Financiamiento = new HashSet<Financiamiento>();
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            NivelAcademico = new HashSet<NivelAcademico>();
            OfertaEducativa = new HashSet<OfertaEducativa>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            Pagare = new HashSet<Pagare>();
            Pago = new HashSet<Pago>();
            PagoConcepto = new HashSet<PagoConcepto>();
            PagoConceptoMaestro = new HashSet<PagoConceptoMaestro>();
            PagoParcial = new HashSet<PagoParcial>();
            PagoPlan = new HashSet<PagoPlan>();
            PolizaAjuste = new HashSet<PolizaAjuste>();
            PromocionCasa = new HashSet<PromocionCasa>();
            Recibo = new HashSet<Recibo>();
            ReclasificacionTipo = new HashSet<ReclasificacionTipo>();
            ReferenciaProcesada = new HashSet<ReferenciaProcesada>();
            UniversidadValidacion = new HashSet<UniversidadValidacion>();
            Usuario = new HashSet<Usuario>();
            UsuarioPasswordRecovery = new HashSet<UsuarioPasswordRecovery>();
        }

        public int EstatusId { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual ICollection<AlumnoDescuentoPendiente> AlumnoDescuentoPendiente { get; set; }
        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoMovimiento> AlumnoMovimiento { get; set; }
        public virtual ICollection<AlumnoPasswordRecovery> AlumnoPasswordRecovery { get; set; }
        public virtual ICollection<Asignatura> Asignatura { get; set; }
        public virtual ICollection<BancoTerminal> BancoTerminal { get; set; }
        public virtual ICollection<Financiamiento> Financiamiento { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<NivelAcademico> NivelAcademico { get; set; }
        public virtual ICollection<OfertaEducativa> OfertaEducativa { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<Pagare> Pagare { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<PagoConcepto> PagoConcepto { get; set; }
        public virtual ICollection<PagoConceptoMaestro> PagoConceptoMaestro { get; set; }
        public virtual ICollection<PagoParcial> PagoParcial { get; set; }
        public virtual ICollection<PagoPlan> PagoPlan { get; set; }
        public virtual ICollection<PolizaAjuste> PolizaAjuste { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasa { get; set; }
        public virtual ICollection<Recibo> Recibo { get; set; }
        public virtual ICollection<ReclasificacionTipo> ReclasificacionTipo { get; set; }
        public virtual ICollection<ReferenciaProcesada> ReferenciaProcesada { get; set; }
        public virtual ICollection<UniversidadValidacion> UniversidadValidacion { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<UsuarioPasswordRecovery> UsuarioPasswordRecovery { get; set; }
    }
}
