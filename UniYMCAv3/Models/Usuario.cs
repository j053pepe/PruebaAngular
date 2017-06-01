using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            AdeudoBiblioteca = new HashSet<AdeudoBiblioteca>();
            Alumno = new HashSet<Alumno>();
            AlumnoAntecedenteBitacora = new HashSet<AlumnoAntecedenteBitacora>();
            AlumnoCuatrimestre = new HashSet<AlumnoCuatrimestre>();
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoDescuentoPendiente = new HashSet<AlumnoDescuentoPendiente>();
            AlumnoExamenMedico = new HashSet<AlumnoExamenMedico>();
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            AlumnoMovimiento = new HashSet<AlumnoMovimiento>();
            AlumnoPermitido = new HashSet<AlumnoPermitido>();
            AlumnoReingresoBitacora = new HashSet<AlumnoReingresoBitacora>();
            AlumnoRevision = new HashSet<AlumnoRevision>();
            BecaDeportiva = new HashSet<BecaDeportiva>();
            CuotaIncremento = new HashSet<CuotaIncremento>();
            Docente1 = new HashSet<Docente1>();
            Empresa = new HashSet<Empresa>();
            Grupo1 = new HashSet<Grupo1>();
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            GrupoAlumnoConfiguracionBitacora = new HashSet<GrupoAlumnoConfiguracionBitacora>();
            GrupoComprobante = new HashSet<GrupoComprobante>();
            Matricula = new HashSet<Matricula>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            Pagare = new HashSet<Pagare>();
            PagoCancelacionDetalle = new HashSet<PagoCancelacionDetalle>();
            PagoParcialBitacora = new HashSet<PagoParcialBitacora>();
            PromocionCasa = new HashSet<PromocionCasa>();
            ProspectoSeguimiento = new HashSet<ProspectoSeguimiento>();
            Recibo = new HashSet<Recibo>();
            ReciboDetalle = new HashSet<ReciboDetalle>();
            Reclasificacion = new HashSet<Reclasificacion>();
            ReferenciadoCabeceroBitacora = new HashSet<ReferenciadoCabeceroBitacora>();
            ReferenciadoDetalleBitacora = new HashSet<ReferenciadoDetalleBitacora>();
            ReferenciaGeneradaBitacora = new HashSet<ReferenciaGeneradaBitacora>();
            SistemaConfiguracion = new HashSet<SistemaConfiguracion>();
            UsuarioBitacora = new HashSet<UsuarioBitacora>();
            UsuarioIngresosBitacora = new HashSet<UsuarioIngresosBitacora>();
            UsuarioPasswordRecovery = new HashSet<UsuarioPasswordRecovery>();
            UsuarioPermisoUsuario = new HashSet<UsuarioPermiso>();
            UsuarioPermisoUsuarioIdAsignacionNavigation = new HashSet<UsuarioPermiso>();
            UsuarioSucursalCaja = new HashSet<UsuarioSucursalCaja>();
            UsuarioTipoPagoConcepto = new HashSet<UsuarioTipoPagoConcepto>();
        }

        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Password { get; set; }
        public int UsuarioTipoId { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<AdeudoBiblioteca> AdeudoBiblioteca { get; set; }
        public virtual AdeudoChocolates AdeudoChocolates { get; set; }
        public virtual ICollection<Alumno> Alumno { get; set; }
        public virtual ICollection<AlumnoAntecedenteBitacora> AlumnoAntecedenteBitacora { get; set; }
        public virtual ICollection<AlumnoCuatrimestre> AlumnoCuatrimestre { get; set; }
        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual ICollection<AlumnoDescuentoPendiente> AlumnoDescuentoPendiente { get; set; }
        public virtual ICollection<AlumnoExamenMedico> AlumnoExamenMedico { get; set; }
        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<AlumnoMovimiento> AlumnoMovimiento { get; set; }
        public virtual ICollection<AlumnoPermitido> AlumnoPermitido { get; set; }
        public virtual ICollection<AlumnoReingresoBitacora> AlumnoReingresoBitacora { get; set; }
        public virtual ICollection<AlumnoRevision> AlumnoRevision { get; set; }
        public virtual ICollection<BecaDeportiva> BecaDeportiva { get; set; }
        public virtual ICollection<CuotaIncremento> CuotaIncremento { get; set; }
        public virtual ICollection<Docente1> Docente1 { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        public virtual ICollection<Grupo1> Grupo1 { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracionBitacora> GrupoAlumnoConfiguracionBitacora { get; set; }
        public virtual ICollection<GrupoComprobante> GrupoComprobante { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<Pagare> Pagare { get; set; }
        public virtual ICollection<PagoCancelacionDetalle> PagoCancelacionDetalle { get; set; }
        public virtual ICollection<PagoParcialBitacora> PagoParcialBitacora { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasa { get; set; }
        public virtual ICollection<ProspectoSeguimiento> ProspectoSeguimiento { get; set; }
        public virtual ICollection<Recibo> Recibo { get; set; }
        public virtual ICollection<ReciboDetalle> ReciboDetalle { get; set; }
        public virtual ICollection<Reclasificacion> Reclasificacion { get; set; }
        public virtual ICollection<ReferenciadoCabeceroBitacora> ReferenciadoCabeceroBitacora { get; set; }
        public virtual ICollection<ReferenciadoDetalleBitacora> ReferenciadoDetalleBitacora { get; set; }
        public virtual ICollection<ReferenciaGeneradaBitacora> ReferenciaGeneradaBitacora { get; set; }
        public virtual ICollection<SistemaConfiguracion> SistemaConfiguracion { get; set; }
        public virtual ICollection<UsuarioBitacora> UsuarioBitacora { get; set; }
        public virtual UsuarioDetalle UsuarioDetalle { get; set; }
        public virtual UsuarioImagen UsuarioImagen { get; set; }
        public virtual ICollection<UsuarioIngresosBitacora> UsuarioIngresosBitacora { get; set; }
        public virtual ICollection<UsuarioPasswordRecovery> UsuarioPasswordRecovery { get; set; }
        public virtual ICollection<UsuarioPermiso> UsuarioPermisoUsuario { get; set; }
        public virtual ICollection<UsuarioPermiso> UsuarioPermisoUsuarioIdAsignacionNavigation { get; set; }
        public virtual ICollection<UsuarioSucursalCaja> UsuarioSucursalCaja { get; set; }
        public virtual ICollection<UsuarioTipoPagoConcepto> UsuarioTipoPagoConcepto { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual UsuarioTipo UsuarioTipo { get; set; }
    }
}
