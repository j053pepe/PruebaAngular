using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            AlumnoAccesoBitacora = new HashSet<AlumnoAccesoBitacora>();
            AlumnoAntecedente = new HashSet<AlumnoAntecedente>();
            AlumnoCuatrimestre = new HashSet<AlumnoCuatrimestre>();
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoDetalleBitacora = new HashSet<AlumnoDetalleBitacora>();
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            AlumnoMovimiento = new HashSet<AlumnoMovimiento>();
            AlumnoPasswordRecovery = new HashSet<AlumnoPasswordRecovery>();
            AlumnoPermitido = new HashSet<AlumnoPermitido>();
            AlumnoReferenciaBitacora = new HashSet<AlumnoReferenciaBitacora>();
            AlumnoReingresoBitacora = new HashSet<AlumnoReingresoBitacora>();
            AlumnoRevision = new HashSet<AlumnoRevision>();
            BecaDeportiva = new HashSet<BecaDeportiva>();
            BitacoraReinscripcionAdeudo = new HashSet<BitacoraReinscripcionAdeudo>();
            Financiamiento = new HashSet<Financiamiento>();
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            IdiomaGrupoAlumno = new HashSet<IdiomaGrupoAlumno>();
            Matricula = new HashSet<Matricula>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            Pagare = new HashSet<Pagare>();
            Pago = new HashSet<Pago>();
            PersonaAutorizada = new HashSet<PersonaAutorizada>();
            PromocionCasaAlumno = new HashSet<PromocionCasa>();
            PromocionCasaAlumnoIdProspectoNavigation = new HashSet<PromocionCasa>();
            Recibo = new HashSet<Recibo>();
            ReferenciaProcesada = new HashSet<ReferenciaProcesada>();
            Respuesta = new HashSet<Respuesta>();
        }

        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public string MatriculaId { get; set; }
        public int Anio { get; set; }
        public int PeriodoId { get; set; }
        public int EstatusId { get; set; }

        public virtual Adeudo Adeudo { get; set; }
        public virtual AdeudoBiblioteca AdeudoBiblioteca { get; set; }
        public virtual AdeudoChocolates AdeudoChocolates { get; set; }
        public virtual ICollection<AlumnoAccesoBitacora> AlumnoAccesoBitacora { get; set; }
        public virtual ICollection<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual ICollection<AlumnoCuatrimestre> AlumnoCuatrimestre { get; set; }
        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual AlumnoDetalle AlumnoDetalle { get; set; }
        public virtual ICollection<AlumnoDetalleBitacora> AlumnoDetalleBitacora { get; set; }
        public virtual AlumnoImagen AlumnoImagen { get; set; }
        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<AlumnoMovimiento> AlumnoMovimiento { get; set; }
        public virtual AlumnoPassword AlumnoPassword { get; set; }
        public virtual ICollection<AlumnoPasswordRecovery> AlumnoPasswordRecovery { get; set; }
        public virtual ICollection<AlumnoPermitido> AlumnoPermitido { get; set; }
        public virtual ICollection<AlumnoReferenciaBitacora> AlumnoReferenciaBitacora { get; set; }
        public virtual ICollection<AlumnoReingresoBitacora> AlumnoReingresoBitacora { get; set; }
        public virtual ICollection<AlumnoRevision> AlumnoRevision { get; set; }
        public virtual AlumnoSaldo AlumnoSaldo { get; set; }
        public virtual ICollection<BecaDeportiva> BecaDeportiva { get; set; }
        public virtual ICollection<BitacoraReinscripcionAdeudo> BitacoraReinscripcionAdeudo { get; set; }
        public virtual ICollection<Financiamiento> Financiamiento { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<IdiomaGrupoAlumno> IdiomaGrupoAlumno { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<Pagare> Pagare { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<PersonaAutorizada> PersonaAutorizada { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasaAlumno { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasaAlumnoIdProspectoNavigation { get; set; }
        public virtual ICollection<Recibo> Recibo { get; set; }
        public virtual ICollection<ReferenciaProcesada> ReferenciaProcesada { get; set; }
        public virtual ICollection<Respuesta> Respuesta { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
