using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UniYMCAv3.Models
{
    public partial class UniversidadContext : DbContext
    {
        public virtual DbSet<Adeudo> Adeudo { get; set; }
        public virtual DbSet<AdeudoBiblioteca> AdeudoBiblioteca { get; set; }
        public virtual DbSet<AdeudoChocolates> AdeudoChocolates { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoAccesoBitacora> AlumnoAccesoBitacora { get; set; }
        public virtual DbSet<AlumnoAntecedente> AlumnoAntecedente { get; set; }
        public virtual DbSet<AlumnoAntecedenteBitacora> AlumnoAntecedenteBitacora { get; set; }
        public virtual DbSet<AlumnoBitacora> AlumnoBitacora { get; set; }
        public virtual DbSet<AlumnoCuatrimestre> AlumnoCuatrimestre { get; set; }
        public virtual DbSet<AlumnoCuatrimestreBitacora> AlumnoCuatrimestreBitacora { get; set; }
        public virtual DbSet<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual DbSet<AlumnoDescuentoBitacora> AlumnoDescuentoBitacora { get; set; }
        public virtual DbSet<AlumnoDescuentoDocumento> AlumnoDescuentoDocumento { get; set; }
        public virtual DbSet<AlumnoDescuentoPendiente> AlumnoDescuentoPendiente { get; set; }
        public virtual DbSet<AlumnoDetalle> AlumnoDetalle { get; set; }
        public virtual DbSet<AlumnoDetalleAlumno> AlumnoDetalleAlumno { get; set; }
        public virtual DbSet<AlumnoDetalleBitacora> AlumnoDetalleBitacora { get; set; }
        public virtual DbSet<AlumnoDetalleCoordinador> AlumnoDetalleCoordinador { get; set; }
        public virtual DbSet<AlumnoExamenMedico> AlumnoExamenMedico { get; set; }
        public virtual DbSet<AlumnoGrupoCuota> AlumnoGrupoCuota { get; set; }
        public virtual DbSet<AlumnoImagen> AlumnoImagen { get; set; }
        public virtual DbSet<AlumnoImagenDetalle> AlumnoImagenDetalle { get; set; }
        public virtual DbSet<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual DbSet<AlumnoInscritoBeca> AlumnoInscritoBeca { get; set; }
        public virtual DbSet<AlumnoInscritoBecaDeportiva> AlumnoInscritoBecaDeportiva { get; set; }
        public virtual DbSet<AlumnoInscritoBecaDocumento> AlumnoInscritoBecaDocumento { get; set; }
        public virtual DbSet<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual DbSet<AlumnoInscritoDetalle> AlumnoInscritoDetalle { get; set; }
        public virtual DbSet<AlumnoInscritoDetalleBitacora> AlumnoInscritoDetalleBitacora { get; set; }
        public virtual DbSet<AlumnoInscritoDocumento> AlumnoInscritoDocumento { get; set; }
        public virtual DbSet<AlumnoMovimiento> AlumnoMovimiento { get; set; }
        public virtual DbSet<AlumnoMovimientoBaja> AlumnoMovimientoBaja { get; set; }
        public virtual DbSet<AlumnoMovimientoCarrera> AlumnoMovimientoCarrera { get; set; }
        public virtual DbSet<AlumnoPassword> AlumnoPassword { get; set; }
        public virtual DbSet<AlumnoPasswordRecovery> AlumnoPasswordRecovery { get; set; }
        public virtual DbSet<AlumnoPermitido> AlumnoPermitido { get; set; }
        public virtual DbSet<AlumnoReferenciaBitacora> AlumnoReferenciaBitacora { get; set; }
        public virtual DbSet<AlumnoReingresoBitacora> AlumnoReingresoBitacora { get; set; }
        public virtual DbSet<AlumnoRevision> AlumnoRevision { get; set; }
        public virtual DbSet<AlumnoSaldo> AlumnoSaldo { get; set; }
        public virtual DbSet<AlumnoSaldoDetalle> AlumnoSaldoDetalle { get; set; }
        public virtual DbSet<AlumnoSaldoGasto> AlumnoSaldoGasto { get; set; }
        public virtual DbSet<AlumnosEmpresa> AlumnosEmpresa { get; set; }
        public virtual DbSet<AntecedenteTipo> AntecedenteTipo { get; set; }
        public virtual DbSet<AreaAcademica> AreaAcademica { get; set; }
        public virtual DbSet<Asignatura> Asignatura { get; set; }
        public virtual DbSet<Asociacion> Asociacion { get; set; }
        public virtual DbSet<AsociacionDetalle> AsociacionDetalle { get; set; }
        public virtual DbSet<BajaMotivo> BajaMotivo { get; set; }
        public virtual DbSet<BancoTerminal> BancoTerminal { get; set; }
        public virtual DbSet<BecaDeportiva> BecaDeportiva { get; set; }
        public virtual DbSet<BitacoraReinscripcionAdeudo> BitacoraReinscripcionAdeudo { get; set; }
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<CajaConfiguracion> CajaConfiguracion { get; set; }
        public virtual DbSet<CalificacionesAntecedente> CalificacionesAntecedente { get; set; }
        public virtual DbSet<CuentaMail> CuentaMail { get; set; }
        public virtual DbSet<Cuota> Cuota { get; set; }
        public virtual DbSet<CuotaIncremento> CuotaIncremento { get; set; }
        public virtual DbSet<DatosFiscales> DatosFiscales { get; set; }
        public virtual DbSet<Defectos> Defectos { get; set; }
        public virtual DbSet<Descuento> Descuento { get; set; }
        public virtual DbSet<DescuentoTipo> DescuentoTipo { get; set; }
        public virtual DbSet<Dia> Dia { get; set; }
        public virtual DbSet<Docente> Docente { get; set; }
        public virtual DbSet<Docente1> Docente1 { get; set; }
        public virtual DbSet<DocenteDetalle> DocenteDetalle { get; set; }
        public virtual DbSet<DocenteDetalle1> DocenteDetalle1 { get; set; }
        public virtual DbSet<DocenteEstudio> DocenteEstudio { get; set; }
        public virtual DbSet<DocentePublicacion> DocentePublicacion { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaDetalle> EmpresaDetalle { get; set; }
        public virtual DbSet<EntidadFederativa> EntidadFederativa { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<Financiamiento> Financiamiento { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Grupo1> Grupo1 { get; set; }
        public virtual DbSet<GrupoAlumno> GrupoAlumno { get; set; }
        public virtual DbSet<GrupoAlumnoBitacora> GrupoAlumnoBitacora { get; set; }
        public virtual DbSet<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual DbSet<GrupoAlumnoConfiguracionBitacora> GrupoAlumnoConfiguracionBitacora { get; set; }
        public virtual DbSet<GrupoBitacora> GrupoBitacora { get; set; }
        public virtual DbSet<GrupoComprobante> GrupoComprobante { get; set; }
        public virtual DbSet<GrupoComprobanteDocumento> GrupoComprobanteDocumento { get; set; }
        public virtual DbSet<GrupoDetalle> GrupoDetalle { get; set; }
        public virtual DbSet<Hora> Hora { get; set; }
        public virtual DbSet<IdiomaGrupo> IdiomaGrupo { get; set; }
        public virtual DbSet<IdiomaGrupoAlumno> IdiomaGrupoAlumno { get; set; }
        public virtual DbSet<IngresosPermiso> IngresosPermiso { get; set; }
        public virtual DbSet<LenguasRelacion> LenguasRelacion { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<MateriaApertura> MateriaApertura { get; set; }
        public virtual DbSet<MateriaCompartida> MateriaCompartida { get; set; }
        public virtual DbSet<MateriaTipo> MateriaTipo { get; set; }
        public virtual DbSet<Matricula> Matricula { get; set; }
        public virtual DbSet<MedioDifusion> MedioDifusion { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Mes> Mes { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<NivelAcademico> NivelAcademico { get; set; }
        public virtual DbSet<OfertaEducativa> OfertaEducativa { get; set; }
        public virtual DbSet<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual DbSet<OfertaEducativaPlan> OfertaEducativaPlan { get; set; }
        public virtual DbSet<OfertaEducativaRequerimiento> OfertaEducativaRequerimiento { get; set; }
        public virtual DbSet<OfertaEducativaTipo> OfertaEducativaTipo { get; set; }
        public virtual DbSet<Pagare> Pagare { get; set; }
        public virtual DbSet<PagareDocumento> PagareDocumento { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<PagoBitacora> PagoBitacora { get; set; }
        public virtual DbSet<PagoCancelacion> PagoCancelacion { get; set; }
        public virtual DbSet<PagoCancelacionDetalle> PagoCancelacionDetalle { get; set; }
        public virtual DbSet<PagoCancelacionSolicitud> PagoCancelacionSolicitud { get; set; }
        public virtual DbSet<PagoConcepto> PagoConcepto { get; set; }
        public virtual DbSet<PagoConceptoCarrera> PagoConceptoCarrera { get; set; }
        public virtual DbSet<PagoConceptoMaestro> PagoConceptoMaestro { get; set; }
        public virtual DbSet<PagoDescripcion> PagoDescripcion { get; set; }
        public virtual DbSet<PagoDescuento> PagoDescuento { get; set; }
        public virtual DbSet<PagoDetalle> PagoDetalle { get; set; }
        public virtual DbSet<PagoMetodo> PagoMetodo { get; set; }
        public virtual DbSet<PagoPagare> PagoPagare { get; set; }
        public virtual DbSet<PagoParcial> PagoParcial { get; set; }
        public virtual DbSet<PagoParcialBitacora> PagoParcialBitacora { get; set; }
        public virtual DbSet<PagoPlan> PagoPlan { get; set; }
        public virtual DbSet<PagoRecargo> PagoRecargo { get; set; }
        public virtual DbSet<PagoTipo> PagoTipo { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<PeriodoAnticipado> PeriodoAnticipado { get; set; }
        public virtual DbSet<PersonaAutorizada> PersonaAutorizada { get; set; }
        public virtual DbSet<PersonaAutorizadaBitacora> PersonaAutorizadaBitacora { get; set; }
        public virtual DbSet<PolizaAjuste> PolizaAjuste { get; set; }
        public virtual DbSet<PolizaCabeceroLayout> PolizaCabeceroLayout { get; set; }
        public virtual DbSet<PolizaConfiguracion> PolizaConfiguracion { get; set; }
        public virtual DbSet<PolizaConsecutivo> PolizaConsecutivo { get; set; }
        public virtual DbSet<PolizaCuadre> PolizaCuadre { get; set; }
        public virtual DbSet<PolizaDetalleLayout> PolizaDetalleLayout { get; set; }
        public virtual DbSet<PolizaMovimiento> PolizaMovimiento { get; set; }
        public virtual DbSet<PolizaNumeracion> PolizaNumeracion { get; set; }
        public virtual DbSet<PolizaSubtipo> PolizaSubtipo { get; set; }
        public virtual DbSet<PolizaTipo> PolizaTipo { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<PreguntaCompuesta> PreguntaCompuesta { get; set; }
        public virtual DbSet<PreguntaConfiguracion> PreguntaConfiguracion { get; set; }
        public virtual DbSet<PreguntaTipo> PreguntaTipo { get; set; }
        public virtual DbSet<PreguntaTipoValores> PreguntaTipoValores { get; set; }
        public virtual DbSet<PreguntaValor> PreguntaValor { get; set; }
        public virtual DbSet<PromocionCasa> PromocionCasa { get; set; }
        public virtual DbSet<Prospecto> Prospecto { get; set; }
        public virtual DbSet<ProspectoBitacora> ProspectoBitacora { get; set; }
        public virtual DbSet<ProspectoDetalle> ProspectoDetalle { get; set; }
        public virtual DbSet<ProspectoDetalleBitacora> ProspectoDetalleBitacora { get; set; }
        public virtual DbSet<ProspectoSeguimiento> ProspectoSeguimiento { get; set; }
        public virtual DbSet<Recibo> Recibo { get; set; }
        public virtual DbSet<ReciboArchivo> ReciboArchivo { get; set; }
        public virtual DbSet<ReciboDetalle> ReciboDetalle { get; set; }
        public virtual DbSet<ReciboMsi> ReciboMsi { get; set; }
        public virtual DbSet<Reclasificacion> Reclasificacion { get; set; }
        public virtual DbSet<ReclasificacionTipo> ReclasificacionTipo { get; set; }
        public virtual DbSet<ReferenciaEspecial> ReferenciaEspecial { get; set; }
        public virtual DbSet<ReferenciaGeneradaBitacora> ReferenciaGeneradaBitacora { get; set; }
        public virtual DbSet<ReferenciaProcesada> ReferenciaProcesada { get; set; }
        public virtual DbSet<ReferenciaTipo> ReferenciaTipo { get; set; }
        public virtual DbSet<ReferenciadoArchivoBitacora> ReferenciadoArchivoBitacora { get; set; }
        public virtual DbSet<ReferenciadoBitacora> ReferenciadoBitacora { get; set; }
        public virtual DbSet<ReferenciadoCabecero> ReferenciadoCabecero { get; set; }
        public virtual DbSet<ReferenciadoCabeceroBitacora> ReferenciadoCabeceroBitacora { get; set; }
        public virtual DbSet<ReferenciadoDetalle> ReferenciadoDetalle { get; set; }
        public virtual DbSet<ReferenciadoDetalleBitacora> ReferenciadoDetalleBitacora { get; set; }
        public virtual DbSet<ReferenciadoLayout> ReferenciadoLayout { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<SalonAsignacion> SalonAsignacion { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<SistemaConfiguracion> SistemaConfiguracion { get; set; }
        public virtual DbSet<SubMenu> SubMenu { get; set; }
        public virtual DbSet<Subperiodo> Subperiodo { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<SucursalAnuncio> SucursalAnuncio { get; set; }
        public virtual DbSet<SucursalCaja> SucursalCaja { get; set; }
        public virtual DbSet<SucursalDetalle> SucursalDetalle { get; set; }
        public virtual DbSet<TempAdeudo> TempAdeudo { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<TipoMovimientoCrud> TipoMovimientoCrud { get; set; }
        public virtual DbSet<TipoUsuarioSubmenu> TipoUsuarioSubmenu { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<UniversidadValidacion> UniversidadValidacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioBitacora> UsuarioBitacora { get; set; }
        public virtual DbSet<UsuarioDetalle> UsuarioDetalle { get; set; }
        public virtual DbSet<UsuarioImagen> UsuarioImagen { get; set; }
        public virtual DbSet<UsuarioImagenDetalle> UsuarioImagenDetalle { get; set; }
        public virtual DbSet<UsuarioIngresosBitacora> UsuarioIngresosBitacora { get; set; }
        public virtual DbSet<UsuarioOrigen> UsuarioOrigen { get; set; }
        public virtual DbSet<UsuarioPasswordRecovery> UsuarioPasswordRecovery { get; set; }
        public virtual DbSet<UsuarioPermiso> UsuarioPermiso { get; set; }
        public virtual DbSet<UsuarioSucursalCaja> UsuarioSucursalCaja { get; set; }
        public virtual DbSet<UsuarioTipo> UsuarioTipo { get; set; }
        public virtual DbSet<UsuarioTipoPagoConcepto> UsuarioTipoPagoConcepto { get; set; }

        // Unable to generate entity type for table 'dbo.ReporteEstadoCuentaDescuento'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Adeudo29ABR2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ReporteEstadoCuentaPagosConcepto'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PagoDescuentoBitacora'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnoMatricula'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tabla2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpReferencias'. Please see the warning messages.
        // Unable to generate entity type for table 'Egresos.DocenteDatosFiscales'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IdiomasInscrito'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnosLE20162'. Please see the warning messages.
        // Unable to generate entity type for table 'Egresos.Grupo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnosLEAgregar20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COLEGIATURA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpRelacionAlumno'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Saldos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BecaSEPBitacora'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpAdeudoCLIPPER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnoPermitido20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alumnos2016-2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Alumnos2016_2_sueltas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Licenciatura_20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Posgrado_20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpGruposEspeciales'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BitacoraCancelacion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UniversidadNewAdeudo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UniversidadAdeudo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UniversidadAdeudo29ABR2016'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BitacoraMatAdelanto'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnoBeca'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpESTXCUAT04MAYO'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdelantoLic_20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AdelantoPos_20162'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AlumnoInscritoBitacoraBKSalome'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpPago'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpAlumnoDescuento'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adeudo>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_Adeudo");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Colegiatura).HasColumnType("decimal");

                entity.Property(e => e.ColegiaturaIdiomas).HasColumnType("decimal");

                entity.Property(e => e.Financiamiento).HasColumnType("decimal");

                entity.Property(e => e.Inscripcion).HasColumnType("decimal");

                entity.Property(e => e.Pagare).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.Adeudo)
                    .HasForeignKey<Adeudo>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Adeudo_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Adeudo)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .HasConstraintName("FK_Adeudo_OfertaEducativa");
            });

            modelBuilder.Entity<AdeudoBiblioteca>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AdeudoBiblioteca_1");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.FechaOperacion).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AdeudoBiblioteca)
                    .HasForeignKey<AdeudoBiblioteca>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudoBiblioteca_Alumno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AdeudoBiblioteca)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudoBiblioteca_Usuario");
            });

            modelBuilder.Entity<AdeudoChocolates>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AdeudoChocolates_1");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.FechaOperacion).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AdeudoChocolates)
                    .HasForeignKey<AdeudoChocolates>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudoChocolates_Alumno");

                entity.HasOne(d => d.AlumnoNavigation)
                    .WithOne(p => p.AdeudoChocolates)
                    .HasForeignKey<AdeudoChocolates>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudoChocolates_Usuario");
            });

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MatriculaId).HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Alumno_Estatus");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Alumno)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Alumno_Usuario");
            });

            modelBuilder.Entity<AlumnoAccesoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.FechaIngreso, e.HoraIngreso })
                    .HasName("PK_BitacoraAlumno");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.HoraIngreso).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoAccesoBitacora)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BitacoraAlumno_Alumno");
            });

            modelBuilder.Entity<AlumnoAntecedente>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.AntecedenteTipoId })
                    .HasName("PK_AlumnoAntecedente");

                entity.Property(e => e.EscuelaEquivalencia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Procedencia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promedio).HasColumnType("decimal");

                entity.Property(e => e.TitulacionMedio)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_Alumno");

                entity.HasOne(d => d.AntecedenteTipo)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.AntecedenteTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_AntecedenteTipo");

                entity.HasOne(d => d.AreaAcademica)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.AreaAcademicaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_AreaAcademica");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_EntidadFederativa");

                entity.HasOne(d => d.MedioDifusion)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.MedioDifusionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_MedioDifusion");

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.MesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_Mes");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.AlumnoAntecedente)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedente_Pais");
            });

            modelBuilder.Entity<AlumnoAntecedenteBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.AntecedenteTipoId, e.UsuarioIdBitacora, e.FechaBitacora, e.HoraBitacora })
                    .HasName("PK_AlumnoAntecedenteBitacora");

                entity.Property(e => e.FechaBitacora).HasColumnType("date");

                entity.Property(e => e.HoraBitacora).HasColumnType("time(0)");

                entity.Property(e => e.EscuelaEquivalencia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Procedencia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Promedio).HasColumnType("decimal");

                entity.Property(e => e.TitulacionMedio)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoAntecedenteBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoAntecedenteBitacora_Usuario");
            });

            modelBuilder.Entity<AlumnoBitacora>(entity =>
            {
                entity.HasKey(e => e.AlumnoIdBitacora)
                    .HasName("PK_AlumnoBitacora");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MatriculaId).HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<AlumnoCuatrimestre>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_AlumnoCuatrimestre");

                entity.Property(e => e.EsRegular).HasColumnName("esRegular");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoCuatrimestre)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoCuatrimestre_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoCuatrimestre)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoCuatrimestre_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoCuatrimestre)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoCuatrimestre_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.AlumnoCuatrimestre)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoCuatrimestre_Periodo");
            });

            modelBuilder.Entity<AlumnoCuatrimestreBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.FechaAsignacion, e.HoraAsignacion })
                    .HasName("PK_AlumnoCuatrimestreBitacora");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");

                entity.Property(e => e.EsRegular).HasColumnName("esRegular");
            });

            modelBuilder.Entity<AlumnoDescuento>(entity =>
            {
                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.EsSep).HasColumnName("EsSEP");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("'10:32:45'");

                entity.Property(e => e.Monto).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_Periodo");

                entity.HasOne(d => d.PagoConcepto)
                    .WithMany(p => p.AlumnoDescuento)
                    .HasForeignKey(d => new { d.PagoConceptoId, d.OfertaEducativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuento_PagoConcepto");
            });

            modelBuilder.Entity<AlumnoDescuentoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoDescuentoId, e.UsuarioId, e.FechaGeneracion, e.HoraGeneracion })
                    .HasName("PK_AlumnoDescuentoBitacora");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("'10:32:45'");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.EsSep).HasColumnName("EsSEP");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.Monto).HasColumnType("decimal");
            });

            modelBuilder.Entity<AlumnoDescuentoDocumento>(entity =>
            {
                entity.HasKey(e => e.AlumnoDescuentoId)
                    .HasName("PK_AlumnoDescuentoDocumento");

                entity.Property(e => e.AlumnoDescuentoId).ValueGeneratedNever();

                entity.Property(e => e.AlumnoDescuentoDocumento1)
                    .IsRequired()
                    .HasColumnName("AlumnoDescuentoDocumento");

                entity.HasOne(d => d.AlumnoDescuento)
                    .WithOne(p => p.AlumnoDescuentoDocumento)
                    .HasForeignKey<AlumnoDescuentoDocumento>(d => d.AlumnoDescuentoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuentoDocumento_AlumnoDescuento");
            });

            modelBuilder.Entity<AlumnoDescuentoPendiente>(entity =>
            {
                entity.HasKey(e => e.AlumnoDescuentoId)
                    .HasName("PK_AlumnoDescuentoPendiente");

                entity.Property(e => e.AlumnoDescuentoId).ValueGeneratedNever();

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaPendiente).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.HoraPendiente).HasColumnType("time(0)");

                entity.HasOne(d => d.AlumnoDescuento)
                    .WithOne(p => p.AlumnoDescuentoPendiente)
                    .HasForeignKey<AlumnoDescuentoPendiente>(d => d.AlumnoDescuentoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuentoPendiente_AlumnoDescuento");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.AlumnoDescuentoPendiente)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuentoPendiente_Estatus");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoDescuentoPendiente)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDescuentoPendiente_Usuario");
            });

            modelBuilder.Entity<AlumnoDetalle>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK__Alumno_D__AE20D928367C1819");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TelefonoCasa)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TelefonoOficina)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TieneExamenMedico).HasDefaultValueSql("0");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoDetalle)
                    .HasForeignKey<AlumnoDetalle>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_Alumno");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.AlumnoDetalleEntidadFederativa)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_EntidadFederativa");

                entity.HasOne(d => d.EntidadNacimiento)
                    .WithMany(p => p.AlumnoDetalleEntidadNacimiento)
                    .HasForeignKey(d => d.EntidadNacimientoId)
                    .HasConstraintName("FK_AlumnoDetalle_EntidadFederativa1");

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.AlumnoDetalle)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_EstadoCivil");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.AlumnoDetalle)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_Genero");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.AlumnoDetalle)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_Pais");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.AlumnoDetalle)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalle_Municipio");
            });

            modelBuilder.Entity<AlumnoDetalleAlumno>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AlumnoDetalleAlumno");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TelefonoCasa)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.AlumnoDetalleAlumno)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleAlumno_EntidadFederativa");

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.AlumnoDetalleAlumno)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleAlumno_EstadoCivil");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.AlumnoDetalleAlumno)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleAlumno_Municipio");
            });

            modelBuilder.Entity<AlumnoDetalleBitacora>(entity =>
            {
                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TelefonoCasa)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TelefonoOficina)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoDetalleBitacora)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleBitacora_Alumno");
            });

            modelBuilder.Entity<AlumnoDetalleCoordinador>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AlumnoDetalleCoordinador");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TelefonoCasa)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.AlumnoDetalleCoordinador)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleCoordinador_EntidadFederativa");

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.AlumnoDetalleCoordinador)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleCoordinador_EstadoCivil");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.AlumnoDetalleCoordinador)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleCoordinador_Municipio");
            });

            modelBuilder.Entity<AlumnoExamenMedico>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AlumnoExamenMedico");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoExamenMedico)
                    .HasForeignKey<AlumnoExamenMedico>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoExamenMedico_AlumnoDetalle");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoExamenMedico)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoExamenMedico_Usuario");
            });

            modelBuilder.Entity<AlumnoGrupoCuota>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_AlumnoGrupoCuota");

                entity.Property(e => e.MontoColegiatura).HasColumnType("decimal");

                entity.Property(e => e.MontoInscripcion).HasColumnType("decimal");
            });

            modelBuilder.Entity<AlumnoImagen>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK__AlumnoIm__90A6AA13C28DBBEE");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Imagen).IsRequired();

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoImagen)
                    .HasForeignKey<AlumnoImagen>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoImagen_Alumno");
            });

            modelBuilder.Entity<AlumnoImagenDetalle>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK__AlumnoDe__90A6AA137ABD199D");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.FechaCarga).HasColumnType("date");

                entity.Property(e => e.HoraCarga).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoImagenDetalle)
                    .HasForeignKey<AlumnoImagenDetalle>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoDetalleImagen_AlumnoImagen");
            });

            modelBuilder.Entity<AlumnoInscrito>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK__Inscrito__7F0796CD04E4BC85");

                entity.Property(e => e.FechaInscripcion).HasColumnType("date");

                entity.Property(e => e.HoraInscripcion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_OfertaEducativa");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.PagoPlanId)
                    .HasConstraintName("FK_AlumnoInscrito_PagoPlan");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_Turno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.AlumnoInscrito)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscrito_Periodo");
            });

            modelBuilder.Entity<AlumnoInscritoBeca>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId, e.FechaAplicacion, e.HoraAplicacion })
                    .HasName("PK_AlumnoInscritoBeca");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.EsSep).HasColumnName("EsSEP");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal");
            });

            modelBuilder.Entity<AlumnoInscritoBecaDeportiva>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId, e.FechaAplicacion, e.HoraAplicacion })
                    .HasName("PK_AlumnoInscritoBecaDeportiva");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal");
            });

            modelBuilder.Entity<AlumnoInscritoBecaDocumento>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_AlumnoInscritoBecaDocumento");
            });

            modelBuilder.Entity<AlumnoInscritoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId, e.FechaInscripcion, e.HoraInscripcion, e.UsuarioId })
                    .HasName("PK_AlumnoInscritoBitacora_1");

                entity.Property(e => e.FechaInscripcion).HasColumnType("date");

                entity.Property(e => e.HoraInscripcion)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("'10:32:45'");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_OfertaEducativa");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => d.PagoPlanId)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_PagoPlan");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_Turno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.AlumnoInscritoBitacora)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoInscritoBitacora_Periodo");
            });

            modelBuilder.Entity<AlumnoInscritoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_AlumnoInscritoDetalle");

                entity.Property(e => e.AdeudoBiblioteca).HasDefaultValueSql("0");

                entity.Property(e => e.BecaAcademica).HasDefaultValueSql("0");

                entity.Property(e => e.BecaComite).HasDefaultValueSql("0");

                entity.Property(e => e.BecaDeportiva).HasDefaultValueSql("0");

                entity.Property(e => e.BecaSep)
                    .HasColumnName("BecaSEP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CargosIniciales).HasDefaultValueSql("0");

                entity.Property(e => e.EstatusId).HasDefaultValueSql("1");

                entity.Property(e => e.FechaAdeudoBiblioteca)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaBecaAcademica)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaBecaComite)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaBecaDeportiva)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaBecaSep)
                    .HasColumnName("FechaBecaSEP")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaCargosIniciales)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaFinanciamiento)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FechaPagare)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.Financiamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Inscripcion).HasDefaultValueSql("0");

                entity.Property(e => e.NuevoIngreso).HasDefaultValueSql("0");

                entity.Property(e => e.Pagare).HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PorcentajeBecaDeportiva)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioAdeudoBiblioteca).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioBecaAcademica).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioBecaComite).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioBecaDeportiva).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioBecaSep)
                    .HasColumnName("UsuarioBecaSEP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioCargosIniciales).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioFinanciamiento).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioInscripcion).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioPagare).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<AlumnoInscritoDetalleBitacora>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK_AlumnoInscritoDetalleBitacora");

                entity.Property(e => e.BecaSep).HasColumnName("BecaSEP");

                entity.Property(e => e.FechaAdeudoBiblioteca).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaBecaAcademica).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaBecaComite).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaBecaDeportiva)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("'01-01-1900'");

                entity.Property(e => e.FechaBecaSep)
                    .HasColumnName("FechaBecaSEP")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FechaBitacota).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaCargosIniciales).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaFinanciamiento).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaInscripcion).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaPagare).HasColumnType("smalldatetime");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal");

                entity.Property(e => e.PorcentajeBecaDeportiva).HasColumnType("decimal");

                entity.Property(e => e.UsuarioBecaSep).HasColumnName("UsuarioBecaSEP");
            });

            modelBuilder.Entity<AlumnoInscritoDocumento>(entity =>
            {
                entity.Property(e => e.FechaDocumento).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<AlumnoMovimiento>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Hora).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoMovimiento)
                    .HasForeignKey(d => d.AlumnoId)
                    .HasConstraintName("FK_AlumnoMovimiento_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.AlumnoMovimiento)
                    .HasForeignKey(d => d.EstatusId)
                    .HasConstraintName("FK_AlumnoMovimiento_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoMovimiento)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .HasConstraintName("FK_AlumnoMovimiento_OfertaEducativa");

                entity.HasOne(d => d.TipoMovimiento)
                    .WithMany(p => p.AlumnoMovimiento)
                    .HasForeignKey(d => d.TipoMovimientoId)
                    .HasConstraintName("FK_AlumnoMovimiento_TipoMovimiento");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoMovimiento)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_AlumnoMovimiento_Usuario");
            });

            modelBuilder.Entity<AlumnoMovimientoBaja>(entity =>
            {
                entity.HasKey(e => e.AlumnoMovimientoId)
                    .HasName("PK_AlumnoMovimientoBaja");

                entity.Property(e => e.AlumnoMovimientoId).ValueGeneratedNever();

                entity.Property(e => e.Observaciones).HasColumnType("varchar(200)");

                entity.HasOne(d => d.AlumnoMovimiento)
                    .WithOne(p => p.AlumnoMovimientoBaja)
                    .HasForeignKey<AlumnoMovimientoBaja>(d => d.AlumnoMovimientoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMovimientoBaja_AlumnoMovimiento");

                entity.HasOne(d => d.BajaMotivo)
                    .WithMany(p => p.AlumnoMovimientoBaja)
                    .HasForeignKey(d => d.BajaMotivoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMovimientoBaja_BajaMotivo");
            });

            modelBuilder.Entity<AlumnoMovimientoCarrera>(entity =>
            {
                entity.HasKey(e => e.AlumnoMovimientoId)
                    .HasName("PK_AlumnoMovimientoCarrera");

                entity.Property(e => e.AlumnoMovimientoId).ValueGeneratedNever();

                entity.Property(e => e.Observaciones).HasColumnType("varchar(200)");

                entity.HasOne(d => d.AlumnoMovimiento)
                    .WithOne(p => p.AlumnoMovimientoCarrera)
                    .HasForeignKey<AlumnoMovimientoCarrera>(d => d.AlumnoMovimientoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMovimientoCarrera_AlumnoMovimiento");
            });

            modelBuilder.Entity<AlumnoPassword>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AlumnoPassword");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoPassword)
                    .HasForeignKey<AlumnoPassword>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoPassword_Alumno");
            });

            modelBuilder.Entity<AlumnoPasswordRecovery>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.FechaGeneracion, e.HoraGeneracion })
                    .HasName("PK__AlumnoPa__FFD71C824B99FF13");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoPasswordRecovery)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoPasswordRecovery_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.AlumnoPasswordRecovery)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoPasswordRecovery_Estatus");
            });

            modelBuilder.Entity<AlumnoPermitido>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.Anio, e.PeriodoId })
                    .HasName("PK__AlumnoPe__90A6AA134824EBCA");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(500)");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoPermitido)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoPermitido_Alumno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoPermitido)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoPermitido_Usuario");
            });

            modelBuilder.Entity<AlumnoReferenciaBitacora>(entity =>
            {
                entity.HasKey(e => e.BitacoraId)
                    .HasName("PK_AdeudosBitacora");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoReferenciaBitacora)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudosBitacora_Alumno");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.AlumnoReferenciaBitacora)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudosBitacora_Pago");

                entity.HasOne(d => d.PagoConcepto)
                    .WithMany(p => p.AlumnoReferenciaBitacora)
                    .HasForeignKey(d => new { d.PagoConceptoId, d.OfertaEducativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AdeudosBitacora_PagoConcepto");
            });

            modelBuilder.Entity<AlumnoReingresoBitacora>(entity =>
            {
                entity.HasKey(e => e.BitacoraId)
                    .HasName("PK_PagoReingresoBitacora");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoReingresoBitacora)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoReingresoBitacora_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoReingresoBitacora)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoReingresoBitacora_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoReingresoBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoReingresoBitacora_Usuario");
            });

            modelBuilder.Entity<AlumnoRevision>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_AlumnoRevision");

                entity.Property(e => e.AdelantoMateria).HasDefaultValueSql("0");

                entity.Property(e => e.AsesoriaEspecial).HasDefaultValueSql("0");

                entity.Property(e => e.FechaRevision).HasColumnType("date");

                entity.Property(e => e.HoraRevision).HasColumnType("time(0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoRevision)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoRevision_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.AlumnoRevision)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoRevision_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.AlumnoRevision)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoRevision_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.AlumnoRevision)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoRevision_Periodo");
            });

            modelBuilder.Entity<AlumnoSaldo>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK_AlumnoSaldo");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Saldo).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithOne(p => p.AlumnoSaldo)
                    .HasForeignKey<AlumnoSaldo>(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoSaldo_Alumno");
            });

            modelBuilder.Entity<AlumnoSaldoDetalle>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoId)
                    .HasName("PK_AlumnoSaldoDetalle");

                entity.Property(e => e.EsReferenciado).HasDefaultValueSql("0");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.SaldoAnterior)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SaldoDespues)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoSaldoDetalle)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoSaldoDetalle_AlumnoSaldo");

                entity.HasOne(d => d.ReferenciaProcesada)
                    .WithMany(p => p.AlumnoSaldoDetalle)
                    .HasForeignKey(d => d.ReferenciaProcesadaId)
                    .HasConstraintName("FK_AlumnoSaldoDetalle_ReferenciaProcesada");
            });

            modelBuilder.Entity<AlumnoSaldoGasto>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoId)
                    .HasName("PK_AlumnoSaldoGasto");

                entity.Property(e => e.FechaGasto).HasColumnType("date");

                entity.Property(e => e.HoraGasto).HasColumnType("time(0)");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.SaldoAnterior)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SaldoDespues)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.AlumnoSaldoGasto)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoSaldoGasto_AlumnoSaldo");
            });

            modelBuilder.Entity<AlumnosEmpresa>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK__AlumnosE__90A6AA138CDAB155");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Colegiatura).HasColumnType("decimal");

                entity.Property(e => e.Inscripcion).HasColumnType("decimal");
            });

            modelBuilder.Entity<AntecedenteTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<AreaAcademica>(entity =>
            {
                entity.Property(e => e.AreaAcademicaId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => new { e.OfertaEducativaId, e.AsignaturaId })
                    .HasName("PK_Asignatura");

                entity.Property(e => e.AsignaturaId).HasColumnType("varchar(10)");

                entity.Property(e => e.AsignaturaSeriacionId).HasColumnType("varchar(10)");

                entity.Property(e => e.Creditos).HasColumnType("decimal");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Asignatura)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Asignatura_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Asignatura)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Asignatura_OfertaEducativa");
            });

            modelBuilder.Entity<Asociacion>(entity =>
            {
                entity.Property(e => e.AsociacionId).ValueGeneratedNever();

                entity.Property(e => e.Abreviacion)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Carpeta)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<AsociacionDetalle>(entity =>
            {
                entity.HasKey(e => e.AsociacionId)
                    .HasName("PK_AsociacionDetalle");

                entity.Property(e => e.AsociacionId).ValueGeneratedNever();

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.BancoCuenta)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Asociacion)
                    .WithOne(p => p.AsociacionDetalle)
                    .HasForeignKey<AsociacionDetalle>(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AsociacionDetalle_Asociacion");
            });

            modelBuilder.Entity<BajaMotivo>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<BancoTerminal>(entity =>
            {
                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TieneMsi).HasColumnName("TieneMSI");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.BancoTerminal)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BancoTerminal_Estatus");

                entity.HasOne(d => d.PagoMetodo)
                    .WithMany(p => p.BancoTerminal)
                    .HasForeignKey(d => d.PagoMetodoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BancoTerminal_PagoMetodo");
            });

            modelBuilder.Entity<BecaDeportiva>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.Anio, e.PeriodoId })
                    .HasName("PK_BecaDeportiva");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.MontoBeca).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.BecaDeportiva)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BecaDeportiva_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.BecaDeportiva)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BecaDeportiva_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.BecaDeportiva)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BecaDeportiva_Usuario");
            });

            modelBuilder.Entity<BitacoraReinscripcionAdeudo>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.FechaOperacion, e.HoraOperacion })
                    .HasName("PK_BitacoraReinscripcionAdeudo");

                entity.Property(e => e.FechaOperacion).HasColumnType("date");

                entity.Property(e => e.HoraOperacion).HasColumnType("time(0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.BitacoraReinscripcionAdeudo)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BitacoraReinscripcionAdeudo_Alumno");
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Mac)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<CajaConfiguracion>(entity =>
            {
                entity.HasKey(e => e.ConfiguracionId)
                    .HasName("PK_Configuracion");

                entity.Property(e => e.ImpresoraRecibo)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ImpresoraReporteria)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.SucursalCaja)
                    .WithMany(p => p.CajaConfiguracion)
                    .HasForeignKey(d => d.SucursalCajaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Configuracion_SucursalCaja");
            });

            modelBuilder.Entity<CalificacionesAntecedente>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId })
                    .HasName("PK_CalificacionesAntecedente");

                entity.Property(e => e.BajaMaterias).HasColumnType("varchar(1000)");

                entity.Property(e => e.CalificacionMaterias).HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<CuentaMail>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Smtp)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Ssl).HasColumnName("SSL");
            });

            modelBuilder.Entity<Cuota>(entity =>
            {
                entity.Property(e => e.Monto).HasColumnType("decimal");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Cuota)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Cuota_OfertaEducativa");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.Cuota)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Cuota_Periodo");

                entity.HasOne(d => d.PagoConcepto)
                    .WithMany(p => p.Cuota)
                    .HasForeignKey(d => new { d.PagoConceptoId, d.OfertaEducativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Cuota_ConceptoPago");
            });

            modelBuilder.Entity<CuotaIncremento>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.PeriodoId, e.OfertaEducativaTipoId, e.PagoConceptoId })
                    .HasName("PK_CuotaIncremento");

                entity.Property(e => e.FechaAutorizacion).HasColumnType("date");

                entity.Property(e => e.HoraAutorizacion).HasColumnType("time(0)");

                entity.Property(e => e.ImporteIncremento).HasColumnType("decimal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.OfertaEducativaTipo)
                    .WithMany(p => p.CuotaIncremento)
                    .HasForeignKey(d => d.OfertaEducativaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CuotaIncremento_OfertaEducativaTipo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.CuotaIncremento)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CuotaIncremento_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.CuotaIncremento)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CuotaIncremento_Periodo");
            });

            modelBuilder.Entity<DatosFiscales>(entity =>
            {
                entity.HasKey(e => e.EmpresaId)
                    .HasName("PK_DatosFiscales");

                entity.Property(e => e.EmpresaId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior).HasColumnType("varchar(30)");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)");

                entity.HasOne(d => d.Empresa)
                    .WithOne(p => p.DatosFiscales)
                    .HasForeignKey<DatosFiscales>(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DatosFiscales_Empresa");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.DatosFiscales)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DatosFiscales_Pais");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.DatosFiscales)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DatosFiscales_Municipio");
            });

            modelBuilder.Entity<Defectos>(entity =>
            {
                entity.HasKey(e => e.DefectoId)
                    .HasName("PK_Defectos");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(500)");

                entity.Property(e => e.DescripcionSolucion).HasColumnType("varchar(500)");

                entity.Property(e => e.FechaDefecto).HasColumnType("date");
            });

            modelBuilder.Entity<Descuento>(entity =>
            {
                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.Property(e => e.MontoMaximo).HasColumnType("decimal");

                entity.Property(e => e.MontoMinimo).HasColumnType("decimal");

                entity.HasOne(d => d.DescuentoTipo)
                    .WithMany(p => p.Descuento)
                    .HasForeignKey(d => d.DescuentoTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Descuento_DescuentoTipo");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Descuento)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Descuento_OfertaEducativa");

                entity.HasOne(d => d.PagoConcepto)
                    .WithMany(p => p.Descuento)
                    .HasForeignKey(d => new { d.PagoConceptoId, d.OfertaEducativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Descuento_ConceptoPago");
            });

            modelBuilder.Entity<DescuentoTipo>(entity =>
            {
                entity.Property(e => e.DescuentoTipoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<Dia>(entity =>
            {
                entity.Property(e => e.DiaId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Docente>(entity =>
            {
                entity.ToTable("Docente", "Egresos");

                entity.Property(e => e.DocenteId).ValueGeneratedNever();

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.HoraAlta).HasColumnType("time(0)");

                entity.Property(e => e.Materno).HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(75)");

                entity.Property(e => e.Paterno).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Docente1>(entity =>
            {
                entity.HasKey(e => e.DocenteId)
                    .HasName("PK_Docente");

                entity.ToTable("Docente");

                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Docente1)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Docente_Usuario");
            });

            modelBuilder.Entity<DocenteDetalle>(entity =>
            {
                entity.HasKey(e => e.DocenteId)
                    .HasName("PK_DocenteDetalle");

                entity.ToTable("DocenteDetalle", "Egresos");

                entity.Property(e => e.DocenteId).ValueGeneratedNever();

                entity.Property(e => e.Calle).HasColumnType("varchar(100)");

                entity.Property(e => e.Celular).HasColumnType("varchar(30)");

                entity.Property(e => e.Colonia).HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaNaciminto).HasColumnType("date");

                entity.Property(e => e.NoExterior).HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior).HasColumnType("varchar(30)");

                entity.Property(e => e.Nss)
                    .HasColumnName("NSS")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TelefonoCasa).HasColumnType("varchar(30)");

                entity.Property(e => e.TelefonoOficina).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<DocenteDetalle1>(entity =>
            {
                entity.HasKey(e => e.DocenteId)
                    .HasName("PK_DocenteDetalle");

                entity.ToTable("DocenteDetalle");

                entity.Property(e => e.DocenteId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)");

                entity.Property(e => e.TelefonoCasa).HasColumnType("varchar(50)");

                entity.Property(e => e.TelefonoCelular).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Docente)
                    .WithOne(p => p.DocenteDetalle1)
                    .HasForeignKey<DocenteDetalle1>(d => d.DocenteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocenteDetalle_Docente");

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.DocenteDetalle1)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocenteDetalle_EstadoCivil");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.DocenteDetalle1)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DocenteDetalle_Genero");
            });

            modelBuilder.Entity<DocenteEstudio>(entity =>
            {
                entity.HasKey(e => new { e.DocenteId, e.Descripcion })
                    .HasName("PK_DocenteAntecedente");

                entity.ToTable("DocenteEstudio", "Egresos");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.FechaExpedicion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Institucion).HasColumnType("varchar(200)");

                entity.Property(e => e.NoCedula).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DocentePublicacion>(entity =>
            {
                entity.HasKey(e => new { e.DocenteId, e.TituloPublicacion })
                    .HasName("PK_DocentePublicacion");

                entity.ToTable("DocentePublicacion", "Egresos");

                entity.Property(e => e.TituloPublicacion).HasColumnType("varchar(200)");

                entity.Property(e => e.Editorial).HasColumnType("varchar(200)");

                entity.Property(e => e.FechaPublicacion).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.NoPagina).HasColumnType("varchar(50)");

                entity.Property(e => e.NoVolumen).HasColumnType("varchar(50)");

                entity.Property(e => e.Titulo).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.Property(e => e.FechaAlta).HasColumnType("date");

                entity.Property(e => e.FechaVigencia).HasColumnType("date");

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasColumnType("varchar(13)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Empresa_Usuario");
            });

            modelBuilder.Entity<EmpresaDetalle>(entity =>
            {
                entity.HasKey(e => e.EmpresaId)
                    .HasName("PK_EmpresaDetalle_1");

                entity.Property(e => e.EmpresaId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.EmailContacto)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior).HasColumnType("varchar(30)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Empresa)
                    .WithOne(p => p.EmpresaDetalle)
                    .HasForeignKey<EmpresaDetalle>(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmpresaDetalle_Empresa");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.EmpresaDetalle)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmpresaDetalle_Pais");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.EmpresaDetalle)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmpresaDetalle_Municipio");
            });

            modelBuilder.Entity<EntidadFederativa>(entity =>
            {
                entity.Property(e => e.EntidadFederativaId).ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnType("char(2)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SeMuestra).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.Property(e => e.EstadoCivilId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Financiamiento>(entity =>
            {
                entity.Property(e => e.Cuota).HasColumnType("decimal");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnType("decimal")
                    .HasComputedColumnSql("round([Cuota]*([Porcentaje]/(100)),(1))")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Financiamiento)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Financiamiento_Alumno");

                entity.HasOne(d => d.CuotaNavigation)
                    .WithMany(p => p.Financiamiento)
                    .HasForeignKey(d => d.CuotaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Financiamiento_Cuota");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Financiamiento)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Financiamiento_Estatus");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.Property(e => e.GeneroId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Grupo1>(entity =>
            {
                entity.HasKey(e => e.GrupoId)
                    .HasName("PK_Grupo_1");

                entity.ToTable("Grupo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.SucursalDireccion)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.Grupo1)
                    .HasForeignKey(d => d.EmpresaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Grupo_Empresa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Grupo1)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Grupo_Usuario");
            });

            modelBuilder.Entity<GrupoAlumno>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.GrupoId })
                    .HasName("PK_GrupoAlumno");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");
            });

            modelBuilder.Entity<GrupoAlumnoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.GrupoId, e.FechaAsignacion, e.HoraAsignacion })
                    .HasName("PK_GrupoAlumnoBitacora_1");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");
            });

            modelBuilder.Entity<GrupoAlumnoConfiguracion>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId })
                    .HasName("PK_GrupoAlumnoConfiguracion");

                entity.Property(e => e.CuotaColegiatura).HasColumnType("decimal");

                entity.Property(e => e.CuotaInscripcion).HasColumnType("decimal");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoAlumnoCuota_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoAlumnoCuota_Estatus");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.GrupoId)
                    .HasConstraintName("FK_GrupoAlumnoConfiguracion_Grupo");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoAlumnoCuota_OfertaEducativa");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.PagoPlanId)
                    .HasConstraintName("FK_GrupoAlumnoCuota_PagoPlan");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.GrupoAlumnoConfiguracion)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoAlumnoCuota_Usuario");
            });

            modelBuilder.Entity<GrupoAlumnoConfiguracionBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId, e.FechaRegistro, e.HoraRegistro })
                    .HasName("PK_GrupoAlumnoConfiguracionBitacora_1");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");

                entity.Property(e => e.CuotaColegiatura).HasColumnType("decimal");

                entity.Property(e => e.CuotaInscripcion).HasColumnType("decimal");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.GrupoAlumnoConfiguracionBitacora)
                    .HasForeignKey(d => d.PagoPlanId)
                    .HasConstraintName("FK_GrupoAlumnoConfiguracionBitacora_PagoPlan");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.GrupoAlumnoConfiguracionBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoAlumnoConfiguracionBitacora_Usuario");
            });

            modelBuilder.Entity<GrupoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.GrupoId, e.EmpresaId, e.FechaModificacion, e.HoraModificacion })
                    .HasName("PK_GrupoBitacora");

                entity.Property(e => e.FechaModificacion).HasColumnType("date");

                entity.Property(e => e.HoraModificacion).HasColumnType("time(0)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.SucursalDireccion)
                    .IsRequired()
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<GrupoComprobante>(entity =>
            {
                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Grupo)
                    .WithMany(p => p.GrupoComprobante)
                    .HasForeignKey(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoComprobante_Grupo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.GrupoComprobante)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoComprobante_Usuario");
            });

            modelBuilder.Entity<GrupoComprobanteDocumento>(entity =>
            {
                entity.HasKey(e => e.GrupoComprobanteId)
                    .HasName("PK_GrupoComprobanteDocumento");

                entity.Property(e => e.GrupoComprobanteId).ValueGeneratedNever();

                entity.Property(e => e.Documento).IsRequired();

                entity.HasOne(d => d.GrupoComprobante)
                    .WithOne(p => p.GrupoComprobanteDocumento)
                    .HasForeignKey<GrupoComprobanteDocumento>(d => d.GrupoComprobanteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoComprobanteDocumento_GrupoComprobante");
            });

            modelBuilder.Entity<GrupoDetalle>(entity =>
            {
                entity.HasKey(e => e.GrupoId)
                    .HasName("PK_GrupoDetalle");

                entity.Property(e => e.GrupoId).ValueGeneratedNever();

                entity.Property(e => e.EsCuotaCongelada).HasDefaultValueSql("0");

                entity.Property(e => e.PorcentajeColegiatura).HasColumnType("decimal");

                entity.Property(e => e.PorcentajeInscripcion).HasColumnType("decimal");

                entity.HasOne(d => d.Cuota)
                    .WithMany(p => p.GrupoDetalle)
                    .HasForeignKey(d => d.CuotaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoDetalle_Cuota1");

                entity.HasOne(d => d.Grupo)
                    .WithOne(p => p.GrupoDetalle)
                    .HasForeignKey<GrupoDetalle>(d => d.GrupoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoDetalle_Grupo");
            });

            modelBuilder.Entity<Hora>(entity =>
            {
                entity.ToTable("Hora", "Egresos");

                entity.Property(e => e.Descripcion).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<IdiomaGrupo>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.HoraRegistro).HasColumnType("time(0)");
            });

            modelBuilder.Entity<IdiomaGrupoAlumno>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.IdiomaGrupoId })
                    .HasName("PK_GrupoIdiomaAlumno");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.TipoCurso).HasColumnType("nchar(10)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.IdiomaGrupoAlumno)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoIdiomaAlumno_Alumno");

                entity.HasOne(d => d.IdiomaGrupo)
                    .WithMany(p => p.IdiomaGrupoAlumno)
                    .HasForeignKey(d => d.IdiomaGrupoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GrupoIdiomaAlumno_GrupoIdioma");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.IdiomaGrupoAlumno)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .HasConstraintName("FK_GrupoIdiomaAlumno_OfertaEducativa");
            });

            modelBuilder.Entity<IngresosPermiso>(entity =>
            {
                entity.HasKey(e => e.IngresosId)
                    .HasName("PK_IngresosPermiso");

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<LenguasRelacion>(entity =>
            {
                entity.HasKey(e => e.CuotaId)
                    .HasName("PK_LenguasRelacion");

                entity.Property(e => e.CuotaId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Cuota)
                    .WithOne(p => p.LenguasRelacion)
                    .HasForeignKey<LenguasRelacion>(d => d.CuotaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LenguasRelacion_Cuota");
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.ToTable("Materia", "Egresos");

                entity.Property(e => e.Clave).HasColumnType("varchar(20)");

                entity.Property(e => e.Creditos).HasColumnType("decimal");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");
            });

            modelBuilder.Entity<MateriaApertura>(entity =>
            {
                entity.ToTable("MateriaApertura", "Egresos");

                entity.Property(e => e.Duracion).HasColumnType("decimal");

                entity.Property(e => e.FechaApertura).HasColumnType("date");
            });

            modelBuilder.Entity<MateriaCompartida>(entity =>
            {
                entity.HasKey(e => new { e.MateriaCompartidadId, e.MateriaAperturaId })
                    .HasName("PK_MateriaCompartida");

                entity.ToTable("MateriaCompartida", "Egresos");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");
            });

            modelBuilder.Entity<MateriaTipo>(entity =>
            {
                entity.ToTable("MateriaTipo", "Egresos");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Matricula>(entity =>
            {
                entity.Property(e => e.MatriculaId).HasColumnType("varchar(50)");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Matricula_Alumno");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMatricula_OfertaEducativa");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMatricula_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.Matricula)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlumnoMatricula_Periodo");
            });

            modelBuilder.Entity<MedioDifusion>(entity =>
            {
                entity.Property(e => e.MedioDifusionId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Mes>(entity =>
            {
                entity.Property(e => e.MesId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => new { e.MunicipioId, e.EntidadFederativaId })
                    .HasName("PK_Municipio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.Municipio)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Municipio_EntidadFederativa");
            });

            modelBuilder.Entity<NivelAcademico>(entity =>
            {
                entity.Property(e => e.NivelAcademicoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.NivelAcademico)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NivelAcademico_Estatus");
            });

            modelBuilder.Entity<OfertaEducativa>(entity =>
            {
                entity.Property(e => e.ClaveContable)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaRvoe).HasColumnType("date");

                entity.Property(e => e.RequiereDeportivo).HasDefaultValueSql("0");

                entity.Property(e => e.Rvoe).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.OfertaEducativa)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativa_Estatus");

                entity.HasOne(d => d.OfertaEducativaTipo)
                    .WithMany(p => p.OfertaEducativa)
                    .HasForeignKey(d => d.OfertaEducativaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativa_OfertaEducativaTipo");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.OfertaEducativa)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativa_Sucursal");
            });

            modelBuilder.Entity<OfertaEducativaAntecedente>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.OfertaEducativaId })
                    .HasName("PK_OfertaEducativaAntecedente");

                entity.Property(e => e.FechaInscripcion).HasColumnType("date");

                entity.Property(e => e.HoraInscripcion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_OfertaEducativa");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.PagoPlanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_PagoPlan");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.TurnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_Turno");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.OfertaEducativaAntecedente)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaAntecedente_Periodo");
            });

            modelBuilder.Entity<OfertaEducativaPlan>(entity =>
            {
                entity.HasOne(d => d.OfertaEducativaTipo)
                    .WithMany(p => p.OfertaEducativaPlan)
                    .HasForeignKey(d => d.OfertaEducativaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaPlan_OfertaEducativaTipo");

                entity.HasOne(d => d.PagoPlan)
                    .WithMany(p => p.OfertaEducativaPlan)
                    .HasForeignKey(d => d.PagoPlanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaPlan_PagoPlan");
            });

            modelBuilder.Entity<OfertaEducativaRequerimiento>(entity =>
            {
                entity.HasKey(e => new { e.OfertaEducativaId, e.NivelAcademicoId })
                    .HasName("PK_OfertaEducativaRequerimiento");

                entity.Property(e => e.Creditos).HasColumnType("decimal");

                entity.HasOne(d => d.NivelAcademico)
                    .WithMany(p => p.OfertaEducativaRequerimiento)
                    .HasForeignKey(d => d.NivelAcademicoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaRequerimiento_NivelAcademico");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.OfertaEducativaRequerimiento)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaRequerimiento_OfertaEducativa");
            });

            modelBuilder.Entity<OfertaEducativaTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.AntecedenteTipo)
                    .WithMany(p => p.OfertaEducativaTipo)
                    .HasForeignKey(d => d.AntecedenteTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfertaEducativaTipo_AntecedenteTipo");
            });

            modelBuilder.Entity<Pagare>(entity =>
            {
                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.Interes).HasColumnType("decimal");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Pagare)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pagare_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Pagare)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pagare_Estatus");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pagare)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pagare_Usuario");
            });

            modelBuilder.Entity<PagareDocumento>(entity =>
            {
                entity.HasKey(e => e.PagareId)
                    .HasName("PK_PagareDocumento");

                entity.Property(e => e.PagareId).ValueGeneratedNever();

                entity.Property(e => e.PagareDocumento1)
                    .IsRequired()
                    .HasColumnName("PagareDocumento");

                entity.HasOne(d => d.Pagare)
                    .WithOne(p => p.PagareDocumento)
                    .HasForeignKey<PagareDocumento>(d => d.PagareId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagareDocumento_Pagare");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.Property(e => e.Cuota).HasColumnType("decimal");

                entity.Property(e => e.EsAnticipado).HasDefaultValueSql("0");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion)
                    .HasColumnType("time(0)")
                    .HasDefaultValueSql("'11:27:00'");

                entity.Property(e => e.PeriodoAnticipadoId).HasDefaultValueSql("0");

                entity.Property(e => e.Promesa).HasColumnType("decimal");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Restante).HasColumnType("decimal");

                entity.Property(e => e.UsuarioId).HasDefaultValueSql("0");

                entity.Property(e => e.UsuarioTipoId).HasDefaultValueSql("1");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_Alumno");

                entity.HasOne(d => d.CuotaNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.CuotaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_Cuota");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_OfertaEducativa");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_Periodo1");

                entity.HasOne(d => d.Subperiodo)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => new { d.PeriodoId, d.SubperiodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pago_Subperiodo");
            });

            modelBuilder.Entity<PagoBitacora>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_PagoBitacora");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.Property(e => e.Cuota).HasColumnType("decimal");

                entity.Property(e => e.FechaBitacora).HasColumnType("smalldatetime");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Promesa).HasColumnType("decimal");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<PagoCancelacion>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_PagoCancelacion");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.HasOne(d => d.Pago)
                    .WithOne(p => p.PagoCancelacion)
                    .HasForeignKey<PagoCancelacion>(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoCancelacion_Pago");
            });

            modelBuilder.Entity<PagoCancelacionDetalle>(entity =>
            {
                entity.HasKey(e => e.PagoCancelacionId)
                    .HasName("PK_PagoCancelacionDetalle_1");

                entity.Property(e => e.FechaCancelacion).HasColumnType("date");

                entity.Property(e => e.HoraCancelacion).HasColumnType("time(0)");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PagoCancelacionDetalle)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoCancelacionDetalle_PagoCancelacion");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PagoCancelacionDetalle)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoCancelacionDetalle_Usuario");
            });

            modelBuilder.Entity<PagoCancelacionSolicitud>(entity =>
            {
                entity.HasKey(e => e.SolicitudId)
                    .HasName("PK__PagoCanc__85E95DC77B9E0E3A");

                entity.Property(e => e.Comentario).HasColumnType("varchar(200)");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.HoraSolicitud).HasColumnType("time(0)");
            });

            modelBuilder.Entity<PagoConcepto>(entity =>
            {
                entity.HasKey(e => new { e.PagoConceptoId, e.OfertaEducativaId })
                    .HasName("PK__Cat_Conc__BD0FFBAD2E1BDC42");

                entity.Property(e => e.ClaveContable).HasColumnType("varchar(5)");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.EsCancelable).HasDefaultValueSql("0");

                entity.Property(e => e.EsIva)
                    .HasColumnName("EsIVA")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TieneDescripcion).HasDefaultValueSql("0");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PagoConcepto)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoConcepto_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.PagoConcepto)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ConceptoPago_OfertaEducativa");
            });

            modelBuilder.Entity<PagoConceptoCarrera>(entity =>
            {
                entity.HasKey(e => new { e.PagoConceptoId, e.OfertaEducativaId })
                    .HasName("PK_PagoConceptoCarrera");

                entity.Property(e => e.CuentaContable).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<PagoConceptoMaestro>(entity =>
            {
                entity.HasKey(e => e.PagoConceptoId)
                    .HasName("PK_PagoConceptoMaestro");

                entity.Property(e => e.PagoConceptoId).ValueGeneratedNever();

                entity.Property(e => e.CuentaContable).HasColumnType("varchar(10)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PagoConceptoMaestro)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoConceptoMaestro_Estatus");
            });

            modelBuilder.Entity<PagoDescripcion>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_PagoDescripcion");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.Pago)
                    .WithOne(p => p.PagoDescripcion)
                    .HasForeignKey<PagoDescripcion>(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoDescripcion_Pago");
            });

            modelBuilder.Entity<PagoDescuento>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.DescuentoId })
                    .HasName("PK__Pago_Des__080098312704CA5F");

                entity.Property(e => e.Monto).HasColumnType("decimal");

                entity.HasOne(d => d.Descuento)
                    .WithMany(p => p.PagoDescuento)
                    .HasForeignKey(d => d.DescuentoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoDescuento_Descuento");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PagoDescuento)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoDescuento_Pago");
            });

            modelBuilder.Entity<PagoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.PagoParcialId, e.PagoMetodoId })
                    .HasName("PK_PagoDetalle_1");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.HasOne(d => d.PagoMetodo)
                    .WithMany(p => p.PagoDetalle)
                    .HasForeignKey(d => d.PagoMetodoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoDetalle_PagoMetodo");

                entity.HasOne(d => d.PagoParcial)
                    .WithMany(p => p.PagoDetalle)
                    .HasForeignKey(d => d.PagoParcialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoDetalle_PagoParcial");
            });

            modelBuilder.Entity<PagoMetodo>(entity =>
            {
                entity.Property(e => e.PagoMetodoId).ValueGeneratedNever();

                entity.Property(e => e.Comision).HasColumnType("decimal");

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<PagoPagare>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.PagareId })
                    .HasName("PK_PagoPagare_1");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pagare)
                    .WithMany(p => p.PagoPagare)
                    .HasForeignKey(d => d.PagareId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoPagare_Pagare");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PagoPagare)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoPagare_Pago");
            });

            modelBuilder.Entity<PagoParcial>(entity =>
            {
                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.HoraPago).HasColumnType("time(0)");

                entity.Property(e => e.Pago).HasColumnType("decimal");

                entity.Property(e => e.ReferenciaProcesadaId).HasDefaultValueSql("NULL");

                entity.Property(e => e.TieneMovimientos).HasDefaultValueSql("0");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PagoParcial)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoParcial_Estatus");

                entity.HasOne(d => d.PagoNavigation)
                    .WithMany(p => p.PagoParcial)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoParcial_Pago");

                entity.HasOne(d => d.PagoTipo)
                    .WithMany(p => p.PagoParcial)
                    .HasForeignKey(d => d.PagoTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoParcial_PagoTipo");

                entity.HasOne(d => d.ReferenciaProcesada)
                    .WithMany(p => p.PagoParcial)
                    .HasForeignKey(d => d.ReferenciaProcesadaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoParcial_ReferenciaProcesada");

                entity.HasOne(d => d.Recibo)
                    .WithMany(p => p.PagoParcial)
                    .HasForeignKey(d => new { d.ReciboId, d.SucursalCajaId })
                    .HasConstraintName("FK_PagoParcial_Recibo");
            });

            modelBuilder.Entity<PagoParcialBitacora>(entity =>
            {
                entity.HasKey(e => new { e.PagoParcialId, e.FechaBitacora, e.HoraBitacora, e.UsuarioId })
                    .HasName("PK_PagoParcialBitacora");

                entity.Property(e => e.FechaBitacora).HasColumnType("date");

                entity.Property(e => e.HoraBitacora).HasColumnType("time(0)");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.HoraPago).HasColumnType("time(0)");

                entity.Property(e => e.Pago).HasColumnType("decimal");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PagoParcialBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoParcialBitacora_Usuario");
            });

            modelBuilder.Entity<PagoPlan>(entity =>
            {
                entity.Property(e => e.PagoPlanId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PlanPago)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PagoPlan)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoPlan_Estatus");
            });

            modelBuilder.Entity<PagoRecargo>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PagoRecargoPago)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoPagoRecargo_Pago");

                entity.HasOne(d => d.PagoIdRecargoNavigation)
                    .WithMany(p => p.PagoRecargoPagoIdRecargoNavigation)
                    .HasForeignKey(d => d.PagoIdRecargo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PagoPagoRecargo_Pago1");
            });

            modelBuilder.Entity<PagoTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.PaisId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Iso)
                    .IsRequired()
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<Parentesco>(entity =>
            {
                entity.Property(e => e.ParentescoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.PeriodoId })
                    .HasName("PK_Cat_Periodos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");
            });

            modelBuilder.Entity<PeriodoAnticipado>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.PeriodoId, e.PeriodoAnticipadoId, e.OfertaEducativaTipoId, e.PagoConceptoId })
                    .HasName("PK_PeriodoAnticipado");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.Property(e => e.ImporteDescuento).HasColumnType("decimal");

                entity.HasOne(d => d.OfertaEducativaTipo)
                    .WithMany(p => p.PeriodoAnticipado)
                    .HasForeignKey(d => d.OfertaEducativaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PeriodoAnticipado_OfertaEducativaTipo");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.PeriodoAnticipado)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PeriodoAnticipado_Periodo");
            });

            modelBuilder.Entity<PersonaAutorizada>(entity =>
            {
                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.PersonaAutorizada)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonaAutorizada_Alumno");

                entity.HasOne(d => d.Parentesco)
                    .WithMany(p => p.PersonaAutorizada)
                    .HasForeignKey(d => d.ParentescoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonaAutorizada_Parentesco");
            });

            modelBuilder.Entity<PersonaAutorizadaBitacora>(entity =>
            {
                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PolizaAjuste>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.FechaAjuste, e.Importe })
                    .HasName("PK_PolizaAjuste");

                entity.Property(e => e.FechaAjuste).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.CuentaDestino)
                    .IsRequired()
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.CuentaOrigen)
                    .IsRequired()
                    .HasColumnType("varchar(9)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PolizaAjuste)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaAjuste_Estatus");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PolizaAjuste)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaAjuste_Pago");
            });

            modelBuilder.Entity<PolizaCabeceroLayout>(entity =>
            {
                entity.HasKey(e => new { e.PolizaTipoId, e.ConfiguracionId })
                    .HasName("PK_PolizaCabeceroLayout");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ValorDefault)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaCabeceroLayout)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaCabeceroLayout_PolizaTipo");
            });

            modelBuilder.Entity<PolizaConfiguracion>(entity =>
            {
                entity.HasKey(e => new { e.AsociacionId, e.PolizaTipoId, e.PolizaSubtipoId })
                    .HasName("PK_PolizaConfiguracion");

                entity.Property(e => e.ArchivoFormato)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ArchivoTipo)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Directorio)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Asociacion)
                    .WithMany(p => p.PolizaConfiguracion)
                    .HasForeignKey(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConfiguracion_Asociacion");

                entity.HasOne(d => d.PolizaSubtipo)
                    .WithMany(p => p.PolizaConfiguracion)
                    .HasForeignKey(d => d.PolizaSubtipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConfiguracion_PolizaSubtipo");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaConfiguracion)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConfiguracion_PolizaTipo");
            });

            modelBuilder.Entity<PolizaConsecutivo>(entity =>
            {
                entity.HasKey(e => new { e.AsociacionId, e.PolizaTipoId, e.PolizaSubtipoId, e.Anio, e.MesId })
                    .HasName("PK_PolizaConsecutivo");

                entity.HasOne(d => d.Asociacion)
                    .WithMany(p => p.PolizaConsecutivo)
                    .HasForeignKey(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConsecutivo_Asociacion");

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.PolizaConsecutivo)
                    .HasForeignKey(d => d.MesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConsecutivo_Mes");

                entity.HasOne(d => d.PolizaSubtipo)
                    .WithMany(p => p.PolizaConsecutivo)
                    .HasForeignKey(d => d.PolizaSubtipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConsecutivo_PolizaSubtipo");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaConsecutivo)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaConsecutivo_PolizaTipo");
            });

            modelBuilder.Entity<PolizaCuadre>(entity =>
            {
                entity.HasKey(e => new { e.FechaGeneracion, e.PolizaTipoId, e.PolizaSubtipoId, e.AsociacionId })
                    .HasName("PK_PolizaCuadre");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.ImporteAjuste).HasColumnType("decimal");

                entity.HasOne(d => d.Asociacion)
                    .WithMany(p => p.PolizaCuadre)
                    .HasForeignKey(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaCuadre_Asociacion");

                entity.HasOne(d => d.PolizaSubtipo)
                    .WithMany(p => p.PolizaCuadre)
                    .HasForeignKey(d => d.PolizaSubtipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaCuadre_PolizaSubtipo");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaCuadre)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaCuadre_PolizaTipo");
            });

            modelBuilder.Entity<PolizaDetalleLayout>(entity =>
            {
                entity.HasKey(e => new { e.PolizaTipoId, e.ConfiguracionId })
                    .HasName("PK_PolizaDetalleLayout");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ValorDefault)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaDetalleLayout)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaDetalleLayout_PolizaTipo");
            });

            modelBuilder.Entity<PolizaMovimiento>(entity =>
            {
                entity.Property(e => e.PolizaMovimientoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<PolizaNumeracion>(entity =>
            {
                entity.HasKey(e => new { e.AsociacionId, e.PolizaTipoId, e.PolizaSubtipoId })
                    .HasName("PK_PolizaNumeracion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Asociacion)
                    .WithMany(p => p.PolizaNumeracion)
                    .HasForeignKey(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaParametros_Asociacion");

                entity.HasOne(d => d.PolizaSubtipo)
                    .WithMany(p => p.PolizaNumeracion)
                    .HasForeignKey(d => d.PolizaSubtipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaNumeracion_PolizaSubtipo");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.PolizaNumeracion)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PolizaNumeracion_PolizaTipo");
            });

            modelBuilder.Entity<PolizaSubtipo>(entity =>
            {
                entity.Property(e => e.PolizaSubtipoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<PolizaTipo>(entity =>
            {
                entity.Property(e => e.PolizaTipoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.SubPregunta).HasColumnType("varchar(200)");

                entity.HasOne(d => d.PreguntaConfiguracion)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.PreguntaConfiguracionId)
                    .HasConstraintName("FK_Pregunta_PreguntaRelacion");
            });

            modelBuilder.Entity<PreguntaCompuesta>(entity =>
            {
                entity.HasKey(e => e.PreguntaConfiguracionId)
                    .HasName("PK_PreguntaCompuesta");

                entity.Property(e => e.PreguntaConfiguracionId).ValueGeneratedNever();

                entity.HasOne(d => d.PreguntaTipo)
                    .WithMany(p => p.PreguntaCompuesta)
                    .HasForeignKey(d => d.PreguntaTipoId)
                    .HasConstraintName("FK_PreguntaCompuesta_PreguntaTipo");

                entity.HasOne(d => d.PreguntaTipoValores)
                    .WithMany(p => p.PreguntaCompuesta)
                    .HasForeignKey(d => d.PreguntaTipoValoresId)
                    .HasConstraintName("FK_PreguntaCompuesta_PreguntaTipoValores");
            });

            modelBuilder.Entity<PreguntaConfiguracion>(entity =>
            {
                entity.Property(e => e.PreguntaConfiguracionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.EsCompuesta).HasColumnName("esCompuesta");

                entity.HasOne(d => d.PreguntaConfiguracionNavigation)
                    .WithOne(p => p.PreguntaConfiguracion)
                    .HasForeignKey<PreguntaConfiguracion>(d => d.PreguntaConfiguracionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PreguntaConfiguracion_PreguntaCompuesta");

                entity.HasOne(d => d.PreguntaTipo)
                    .WithMany(p => p.PreguntaConfiguracion)
                    .HasForeignKey(d => d.PreguntaTipoId)
                    .HasConstraintName("FK_PreguntaRelacion_PreguntaTipo2");
            });

            modelBuilder.Entity<PreguntaTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Valor)
                    .WithMany(p => p.PreguntaTipo)
                    .HasForeignKey(d => d.ValorId)
                    .HasConstraintName("FK_PreguntaTipo_PreguntaValor");
            });

            modelBuilder.Entity<PreguntaTipoValores>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.HasOne(d => d.PreguntaTipo)
                    .WithMany(p => p.PreguntaTipoValores)
                    .HasForeignKey(d => d.PreguntaTipoId)
                    .HasConstraintName("FK_PreguntaTipoValores_PreguntaTipo1");
            });

            modelBuilder.Entity<PreguntaValor>(entity =>
            {
                entity.HasKey(e => e.ValorId)
                    .HasName("PK_PreguntaValor");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<PromocionCasa>(entity =>
            {
                entity.HasKey(e => new { e.AlumnoId, e.Anio, e.PeriodoId })
                    .HasName("PK_PromocionCasa");

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraAplicacion).HasColumnType("time(0)");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.Property(e => e.Monto).HasColumnType("decimal");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.PromocionCasaAlumno)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PromocionCasa_Alumno");

                entity.HasOne(d => d.AlumnoIdProspectoNavigation)
                    .WithMany(p => p.PromocionCasaAlumnoIdProspectoNavigation)
                    .HasForeignKey(d => d.AlumnoIdProspecto)
                    .HasConstraintName("FK_PromocionCasa_Alumno1");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.PromocionCasa)
                    .HasForeignKey(d => d.EstatusId)
                    .HasConstraintName("FK_PromocionCasa_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.PromocionCasa)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .HasConstraintName("FK_PromocionCasa_OfertaEducativa");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.PromocionCasa)
                    .HasForeignKey(d => d.PagoId)
                    .HasConstraintName("FK_PromocionCasa_Pago");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PromocionCasa)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_PromocionCasa_Usuario");

                entity.HasOne(d => d.Periodo)
                    .WithMany(p => p.PromocionCasa)
                    .HasForeignKey(d => new { d.Anio, d.PeriodoId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PromocionCasa_Periodo");
            });

            modelBuilder.Entity<Prospecto>(entity =>
            {
                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProspectoBitacora>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProspectoDetalle>(entity =>
            {
                entity.HasKey(e => e.ProspectoId)
                    .HasName("PK__Prospect__411829520FB750B3");

                entity.Property(e => e.ProspectoId).ValueGeneratedNever();

                entity.Property(e => e.Calle).HasColumnType("varchar(100)");

                entity.Property(e => e.Celular).HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia).HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("char(5)");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NoExterior).HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior).HasColumnType("varchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(300)");

                entity.Property(e => e.PrepaProcedencia).HasColumnType("varchar(100)");

                entity.Property(e => e.PrepaPromedio).HasColumnType("decimal");

                entity.Property(e => e.Telefono).HasColumnType("varchar(50)");

                entity.Property(e => e.UniversidadMotivo).HasColumnType("varchar(300)");

                entity.Property(e => e.UniversidadProcedencia).HasColumnType("varchar(100)");

                entity.HasOne(d => d.EntidadFederativa)
                    .WithMany(p => p.ProspectoDetalleEntidadFederativa)
                    .HasForeignKey(d => d.EntidadFederativaId)
                    .HasConstraintName("FK_ProspectoDetalle_EntidadFederativa");

                entity.HasOne(d => d.EstadoCivil)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.EstadoCivilId)
                    .HasConstraintName("FK_ProspectoDetalle_EstadoCivil");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.GeneroId)
                    .HasConstraintName("FK_ProspectoDetalle_Genero");

                entity.HasOne(d => d.MedioDifusion)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.MedioDifusionId)
                    .HasConstraintName("FK_ProspectoDetalle_MedioDifusion");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .HasConstraintName("FK_ProspectoDetalle_OfertaEducativa");

                entity.HasOne(d => d.OfertaEducativaTipo)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.OfertaEducativaTipoId)
                    .HasConstraintName("FK_ProspectoDetalle_OfertaEducativaTipo");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.ProspectoDetallePais)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("FK_ProspectoDetalle_Pais");

                entity.HasOne(d => d.PrepaAreaNavigation)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.PrepaArea)
                    .HasConstraintName("FK_ProspectoDetalle_AreaAcademica");

                entity.HasOne(d => d.PrepaEntidad)
                    .WithMany(p => p.ProspectoDetallePrepaEntidad)
                    .HasForeignKey(d => d.PrepaEntidadId)
                    .HasConstraintName("FK_ProspectoDetalle_EntidadFederativa1");

                entity.HasOne(d => d.PrepaPais)
                    .WithMany(p => p.ProspectoDetallePrepaPais)
                    .HasForeignKey(d => d.PrepaPaisId)
                    .HasConstraintName("FK_ProspectoDetalle_Pais1");

                entity.HasOne(d => d.Prospecto)
                    .WithOne(p => p.ProspectoDetalle)
                    .HasForeignKey<ProspectoDetalle>(d => d.ProspectoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProspectoDetalle_Prospecto");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK_ProspectoDetalle_Sucursal");

                entity.HasOne(d => d.Turno)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => d.TurnoId)
                    .HasConstraintName("FK_ProspectoDetalle_Turno");

                entity.HasOne(d => d.UniversidadEntidad)
                    .WithMany(p => p.ProspectoDetalleUniversidadEntidad)
                    .HasForeignKey(d => d.UniversidadEntidadId)
                    .HasConstraintName("FK_ProspectoDetalle_EntidadFederativa2");

                entity.HasOne(d => d.UniversidadPais)
                    .WithMany(p => p.ProspectoDetalleUniversidadPais)
                    .HasForeignKey(d => d.UniversidadPaisId)
                    .HasConstraintName("FK_ProspectoDetalle_Pais2");

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.ProspectoDetalle)
                    .HasForeignKey(d => new { d.MunicipioId, d.EntidadFederativaId })
                    .HasConstraintName("FK_ProspectoDetalle_Municipio");
            });

            modelBuilder.Entity<ProspectoDetalleBitacora>(entity =>
            {
                entity.Property(e => e.Calle).HasColumnType("varchar(100)");

                entity.Property(e => e.Celular).HasColumnType("varchar(50)");

                entity.Property(e => e.Colonia).HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasColumnType("char(5)");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.NoExterior).HasColumnType("varchar(30)");

                entity.Property(e => e.NoInterior).HasColumnType("varchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(300)");

                entity.Property(e => e.PrepaProcedencia).HasColumnType("varchar(100)");

                entity.Property(e => e.PrepaPromedio).HasColumnType("decimal");

                entity.Property(e => e.Telefono).HasColumnType("varchar(50)");

                entity.Property(e => e.UniversidadMotivo).HasColumnType("varchar(300)");

                entity.Property(e => e.UniversidadProcedencia).HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<ProspectoSeguimiento>(entity =>
            {
                entity.HasKey(e => new { e.ProspectoSeguimientoId, e.ProspectoId, e.FechaComentario })
                    .HasName("PK__Seguimie__D75C1F680AF29B96");

                entity.Property(e => e.ProspectoSeguimientoId).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaComentario).HasColumnType("date");

                entity.Property(e => e.Comentario)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Prospecto)
                    .WithMany(p => p.ProspectoSeguimiento)
                    .HasForeignKey(d => d.ProspectoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProspectoSeguimiento_Prospecto");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ProspectoSeguimiento)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProspectoSeguimiento_Usuario");
            });

            modelBuilder.Entity<Recibo>(entity =>
            {
                entity.HasKey(e => new { e.ReciboId, e.SucursalCajaId })
                    .HasName("PK_Recibo_1");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Recibo)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Recibo_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Recibo)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Recibo_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.Recibo)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Recibo_OfertaEducativa");

                entity.HasOne(d => d.SucursalCaja)
                    .WithMany(p => p.Recibo)
                    .HasForeignKey(d => d.SucursalCajaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Recibo_SucursalCaja");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Recibo)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Recibo_Usuario");
            });

            modelBuilder.Entity<ReciboArchivo>(entity =>
            {
                entity.HasKey(e => new { e.SucursalCajaId, e.ReciboId })
                    .HasName("PK_ReciboArchivo");

                entity.Property(e => e.Archivo).IsRequired();

                entity.HasOne(d => d.SucursalCaja)
                    .WithMany(p => p.ReciboArchivo)
                    .HasForeignKey(d => d.SucursalCajaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboArchivo_SucursalCaja");

                entity.HasOne(d => d.Recibo)
                    .WithMany(p => p.ReciboArchivo)
                    .HasForeignKey(d => new { d.ReciboId, d.SucursalCajaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboArchivo_Recibo");
            });

            modelBuilder.Entity<ReciboDetalle>(entity =>
            {
                entity.HasKey(e => new { e.ReciboId, e.SucursalCajaId })
                    .HasName("PK_ReciboDetalle");

                entity.Property(e => e.FechaCancelacion).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ReciboDetalle)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboDetalle_Usuario");

                entity.HasOne(d => d.Recibo)
                    .WithOne(p => p.ReciboDetalle)
                    .HasForeignKey<ReciboDetalle>(d => new { d.ReciboId, d.SucursalCajaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboDetalle_Recibo");
            });

            modelBuilder.Entity<ReciboMsi>(entity =>
            {
                entity.HasKey(e => new { e.ReciboId, e.SucursalCajaId })
                    .HasName("PK_ReciboMSI");

                entity.ToTable("ReciboMSI");

                entity.Property(e => e.Msi).HasColumnName("MSI");

                entity.HasOne(d => d.BancoTerminal)
                    .WithMany(p => p.ReciboMsi)
                    .HasForeignKey(d => d.BancoTerminalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboMSI_BancoTerminal");

                entity.HasOne(d => d.Recibo)
                    .WithOne(p => p.ReciboMsi)
                    .HasForeignKey<ReciboMsi>(d => new { d.ReciboId, d.SucursalCajaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReciboMSI_Recibo");
            });

            modelBuilder.Entity<Reclasificacion>(entity =>
            {
                entity.Property(e => e.FechaReclasificacion).HasColumnType("date");

                entity.Property(e => e.HoraReclasificacion).HasColumnType("time(0)");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.HasOne(d => d.PagoParcial)
                    .WithMany(p => p.Reclasificacion)
                    .HasForeignKey(d => d.PagoParcialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reclasificacion_PagoParcial");

                entity.HasOne(d => d.ReclasificacionTipo)
                    .WithMany(p => p.Reclasificacion)
                    .HasForeignKey(d => d.ReclasificacionTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reclasificacion_ReclasificacionTipo");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Reclasificacion)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reclasificacion_Usuario");
            });

            modelBuilder.Entity<ReclasificacionTipo>(entity =>
            {
                entity.Property(e => e.CuentaBase)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.ReclasificacionTipo)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReclasificacionTipo_Estatus");
            });

            modelBuilder.Entity<ReferenciaEspecial>(entity =>
            {
                entity.HasKey(e => e.ConsecutivoId)
                    .HasName("PK_ReferenciaEspecial");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.Movimiento)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ReferenciaGeneradaBitacora>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_ReferenciaGeneradaBitacora");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.HasOne(d => d.Pago)
                    .WithOne(p => p.ReferenciaGeneradaBitacora)
                    .HasForeignKey<ReferenciaGeneradaBitacora>(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciaGeneradaBitacora_Pago");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ReferenciaGeneradaBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciaGeneradaBitacora_Usuario");
            });

            modelBuilder.Entity<ReferenciaProcesada>(entity =>
            {
                entity.Property(e => e.EsIngles).HasDefaultValueSql("0");

                entity.Property(e => e.EstatusId).HasDefaultValueSql("1");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ReferenciaTipoId).HasDefaultValueSql("1");

                entity.Property(e => e.Restante).HasColumnType("decimal");

                entity.Property(e => e.SeGasto).HasDefaultValueSql("1");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.ReferenciaProcesada)
                    .HasForeignKey(d => d.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciaProcesada_Alumno");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.ReferenciaProcesada)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciaProcesada_Estatus");

                entity.HasOne(d => d.ReferenciaTipo)
                    .WithMany(p => p.ReferenciaProcesada)
                    .HasForeignKey(d => d.ReferenciaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciaProcesada_ReferenciaTipo");
            });

            modelBuilder.Entity<ReferenciaTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ReferenciadoArchivoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.AsociacionId, e.PolizaTipoId, e.PolizaSubtipoId, e.NombreArchivo, e.FechaArchivo })
                    .HasName("PK_ReferenciadoArchivoBitacora");

                entity.Property(e => e.NombreArchivo).HasColumnType("varchar(50)");

                entity.Property(e => e.FechaArchivo).HasColumnType("date");

                entity.Property(e => e.FechaProcesado).HasColumnType("date");

                entity.Property(e => e.GeneroPoliza).HasDefaultValueSql("1");

                entity.Property(e => e.HoraProcesado).HasColumnType("time(0)");

                entity.HasOne(d => d.Asociacion)
                    .WithMany(p => p.ReferenciadoArchivoBitacora)
                    .HasForeignKey(d => d.AsociacionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoArchivoBitacora_Asociacion");

                entity.HasOne(d => d.PolizaSubtipo)
                    .WithMany(p => p.ReferenciadoArchivoBitacora)
                    .HasForeignKey(d => d.PolizaSubtipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoArchivoBitacora_PolizaSubtipo");

                entity.HasOne(d => d.PolizaTipo)
                    .WithMany(p => p.ReferenciadoArchivoBitacora)
                    .HasForeignKey(d => d.PolizaTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoArchivoBitacora_PolizaTipo");
            });

            modelBuilder.Entity<ReferenciadoBitacora>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.ReferenciaId, e.FechaPago, e.Importe })
                    .HasName("PK_ReferenciadoBitacora");

                entity.Property(e => e.ReferenciaId).HasColumnType("varchar(10)");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.FechaProcesado).HasColumnType("date");

                entity.Property(e => e.HoraProcesado).HasColumnType("time(0)");

                entity.Property(e => e.Movimiento)
                    .IsRequired()
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<ReferenciadoCabecero>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_ReferenciadoCabecero_1");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.ImporteRestante).HasColumnType("decimal");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pago)
                    .WithOne(p => p.ReferenciadoCabecero)
                    .HasForeignKey<ReferenciadoCabecero>(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoCabecero_Pago");
            });

            modelBuilder.Entity<ReferenciadoCabeceroBitacora>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK_ReferenciadoCabeceroBitacora_1");

                entity.Property(e => e.PagoId).ValueGeneratedNever();

                entity.Property(e => e.FechaAplicacion).HasColumnType("date");

                entity.Property(e => e.FechaBitacora).HasColumnType("date");

                entity.Property(e => e.ImporteRestante).HasColumnType("decimal");

                entity.Property(e => e.ImporteTotal).HasColumnType("decimal");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pago)
                    .WithOne(p => p.ReferenciadoCabeceroBitacora)
                    .HasForeignKey<ReferenciadoCabeceroBitacora>(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoCabeceroBitacora_Pago");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ReferenciadoCabeceroBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoCabeceroBitacora_Usuario");
            });

            modelBuilder.Entity<ReferenciadoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.FechaPago, e.Importe, e.HoraProcesado })
                    .HasName("PK_ReferenciadoDetalle_1");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.HoraProcesado).HasColumnType("time(0)");

                entity.Property(e => e.EsReferenciado).HasDefaultValueSql("0");

                entity.Property(e => e.FechaProcesado).HasColumnType("date");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.ReferenciadoDetalle)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoDetalle_ReferenciadoCabecero1");

                entity.HasOne(d => d.ReferenciaProcesada)
                    .WithMany(p => p.ReferenciadoDetalle)
                    .HasForeignKey(d => d.ReferenciaProcesadaId)
                    .HasConstraintName("FK_ReferenciadoDetalle_ReferenciaProcesada");
            });

            modelBuilder.Entity<ReferenciadoDetalleBitacora>(entity =>
            {
                entity.HasKey(e => new { e.PagoId, e.FechaPago, e.Importe, e.HoraProcesado })
                    .HasName("PK_ReferenciadoDetalleBitacora");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.Importe).HasColumnType("decimal");

                entity.Property(e => e.HoraProcesado).HasColumnType("time(0)");

                entity.Property(e => e.FechaBitacora).HasColumnType("date");

                entity.Property(e => e.FechaProcesado).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ReferenciaId)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Pago)
                    .WithMany(p => p.ReferenciadoDetalleBitacora)
                    .HasForeignKey(d => d.PagoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoDetalleBitacora_ReferenciadoCabecero1");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ReferenciadoDetalleBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReferenciadoDetalleBitacora_Usuario");
            });

            modelBuilder.Entity<ReferenciadoLayout>(entity =>
            {
                entity.HasKey(e => e.ReferenciaConfiguracionId)
                    .HasName("PK_ReferenciaConfiguracion");

                entity.Property(e => e.Banco)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Respuesta>(entity =>
            {
                entity.Property(e => e.Comentario).HasColumnType("varchar(300)");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.HasOne(d => d.Alumno)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.AlumnoId)
                    .HasConstraintName("FK_Respuesta_Alumno");

                entity.HasOne(d => d.Pregunta)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.PreguntaId)
                    .HasConstraintName("FK_Respuesta_Pregunta2");

                entity.HasOne(d => d.PreguntaTipoValoresId1Navigation)
                    .WithMany(p => p.RespuestaPreguntaTipoValoresId1Navigation)
                    .HasForeignKey(d => d.PreguntaTipoValoresId1)
                    .HasConstraintName("FK_Respuesta_PreguntaTipoValores2");

                entity.HasOne(d => d.PreguntaTipoValoresId2Navigation)
                    .WithMany(p => p.RespuestaPreguntaTipoValoresId2Navigation)
                    .HasForeignKey(d => d.PreguntaTipoValoresId2)
                    .HasConstraintName("FK_Respuesta_PreguntaTipoValores3");
            });

            modelBuilder.Entity<Salon>(entity =>
            {
                entity.ToTable("Salon", "Egresos");

                entity.Property(e => e.SalonId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.Detalle).HasColumnType("varchar(300)");
            });

            modelBuilder.Entity<SalonAsignacion>(entity =>
            {
                entity.ToTable("SalonAsignacion", "Egresos");

                entity.Property(e => e.SalonAsignacionId).ValueGeneratedNever();

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.ToTable("Sede", "Egresos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<SistemaConfiguracion>(entity =>
            {
                entity.HasKey(e => e.ParametroId)
                    .HasName("PK_SistemaConfiguracion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Parametro)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.SistemaConfiguracion)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SistemaConfiguracion_Usuario");
            });

            modelBuilder.Entity<SubMenu>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.SubMenu)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SubMenu_Menu");
            });

            modelBuilder.Entity<Subperiodo>(entity =>
            {
                entity.HasKey(e => new { e.PeriodoId, e.SubperiodoId })
                    .HasName("PK__Cat_SubP__62C4CF6E0A338187");

                entity.HasOne(d => d.Mes)
                    .WithMany(p => p.Subperiodo)
                    .HasForeignKey(d => d.MesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Subperiodo_Mes");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.Property(e => e.ClaveDescuentos)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ClaveIngreso)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ClaveOtros)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.DescripcionId)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnType("varchar(2)");
            });

            modelBuilder.Entity<SucursalAnuncio>(entity =>
            {
                entity.HasKey(e => e.AnuncioId)
                    .HasName("PK_Anuncio");

                entity.Property(e => e.AnuncioId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SucursalAnuncio)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Anuncio_Sucursal");
            });

            modelBuilder.Entity<SucursalCaja>(entity =>
            {
                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.SucursalCaja)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SucursalCaja_Caja");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.SucursalCaja)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SucursalCaja_Sucursal");
            });

            modelBuilder.Entity<SucursalDetalle>(entity =>
            {
                entity.HasKey(e => e.SucursalId)
                    .HasName("PK__Sucursal__ACF7C12F65C116E7");

                entity.Property(e => e.SucursalId).ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Delegacion)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.SucursalDetalle)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SucursalDetalle_Pais");

                entity.HasOne(d => d.Sucursal)
                    .WithOne(p => p.SucursalDetalle)
                    .HasForeignKey<SucursalDetalle>(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SucursalDetalle_Sucursal");
            });

            modelBuilder.Entity<TempAdeudo>(entity =>
            {
                entity.HasKey(e => e.AlumnoId)
                    .HasName("PK__TempAdeu__90A6AA135F3A01D7");

                entity.Property(e => e.AlumnoId).ValueGeneratedNever();

                entity.Property(e => e.Adeudo).HasColumnType("decimal");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TipoDocumento1)
                    .HasName("PK_TipoDocumento");

                entity.Property(e => e.TipoDocumento1)
                    .HasColumnName("TipoDocumento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TipoMovimientoCrud>(entity =>
            {
                entity.HasKey(e => e.TipoMovimientoId)
                    .HasName("PK_TipoMovimientoCRUD");

                entity.ToTable("TipoMovimientoCRUD");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TipoUsuarioSubmenu>(entity =>
            {
                entity.HasOne(d => d.Submenu)
                    .WithMany(p => p.TipoUsuarioSubmenu)
                    .HasForeignKey(d => d.SubmenuId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TipoUsuarioSubmenu_SubMenu");

                entity.HasOne(d => d.UsuarioTipo)
                    .WithMany(p => p.TipoUsuarioSubmenu)
                    .HasForeignKey(d => d.UsuarioTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TipoUsuarioSubmenu_UsuarioTipo");
            });

            modelBuilder.Entity<Turno>(entity =>
            {
                entity.Property(e => e.TurnoId).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<UniversidadValidacion>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("PK_UniversidadValidacion");

                entity.Property(e => e.UsuarioId).ValueGeneratedNever();

                entity.Property(e => e.Adeudo).HasColumnType("decimal");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.HoraFinal).HasColumnType("time(0)");

                entity.Property(e => e.HoraInicio).HasColumnType("time(0)");

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nocturno).HasDefaultValueSql("0");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.UniversidadValidacion)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UniversidadValidacion_Estatus");

                entity.HasOne(d => d.OfertaEducativa)
                    .WithMany(p => p.UniversidadValidacion)
                    .HasForeignKey(d => d.OfertaEducativaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UniversidadValidacion_OfertaEducativa");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.UsuarioId).ValueGeneratedNever();

                entity.Property(e => e.Materno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Usuario_Estatus");

                entity.HasOne(d => d.UsuarioTipo)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.UsuarioTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Usuario_UsuarioTipo");
            });

            modelBuilder.Entity<UsuarioBitacora>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.FechaIngreso, e.HoraIngreso })
                    .HasName("PK_UsuarioBitacora");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.HoraIngreso).HasColumnType("time(0)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioBitacora_Usuario");
            });

            modelBuilder.Entity<UsuarioDetalle>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("PK__UsuarioD__2B3DE7B8BB2875D0");

                entity.Property(e => e.UsuarioId).ValueGeneratedNever();

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Genero)
                    .WithMany(p => p.UsuarioDetalle)
                    .HasForeignKey(d => d.GeneroId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioDetalle_Genero");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.UsuarioDetalle)
                    .HasForeignKey<UsuarioDetalle>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioDetalle_Usuario");
            });

            modelBuilder.Entity<UsuarioImagen>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("PK__UsuarioI__2B3DE7B89FFCA0F0");

                entity.Property(e => e.UsuarioId).ValueGeneratedNever();

                entity.Property(e => e.Imagen).IsRequired();

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.UsuarioImagen)
                    .HasForeignKey<UsuarioImagen>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioImagen_Usuario");
            });

            modelBuilder.Entity<UsuarioImagenDetalle>(entity =>
            {
                entity.HasKey(e => e.UsuarioId)
                    .HasName("PK_UsuarioDetalleImagen");

                entity.Property(e => e.UsuarioId).ValueGeneratedNever();

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.FechaCarga).HasColumnType("date");

                entity.Property(e => e.HoraCarga).HasColumnType("time(0)");

                entity.HasOne(d => d.Usuario)
                    .WithOne(p => p.UsuarioImagenDetalle)
                    .HasForeignKey<UsuarioImagenDetalle>(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioDetalleImagen_UsuarioImagen");
            });

            modelBuilder.Entity<UsuarioIngresosBitacora>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.FechaIngreso, e.HoraIngreso })
                    .HasName("PK_UsuarioIngresosBitacora");

                entity.Property(e => e.FechaIngreso).HasColumnType("date");

                entity.Property(e => e.HoraIngreso).HasColumnType("time(0)");

                entity.Property(e => e.HoraSalida).HasColumnType("time(0)");

                entity.Property(e => e.TipoIngreso)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioIngresosBitacora)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioIngresosBitacora_Usuario");
            });

            modelBuilder.Entity<UsuarioOrigen>(entity =>
            {
                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<UsuarioPasswordRecovery>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.FechaGeneracion, e.HoraGeneracion })
                    .HasName("PK_UsuarioPasswordRecovery");

                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.HoraGeneracion).HasColumnType("time(0)");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Estatus)
                    .WithMany(p => p.UsuarioPasswordRecovery)
                    .HasForeignKey(d => d.EstatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioPasswordRecovery_Estatus");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioPasswordRecovery)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioPasswordRecovery_Usuario");
            });

            modelBuilder.Entity<UsuarioPermiso>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.IngresosId })
                    .HasName("PK_UsuarioPermiso");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");

                entity.HasOne(d => d.Ingresos)
                    .WithMany(p => p.UsuarioPermiso)
                    .HasForeignKey(d => d.IngresosId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioPermiso_IngresosPermiso");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioPermisoUsuario)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioPermiso_Usuario");

                entity.HasOne(d => d.UsuarioIdAsignacionNavigation)
                    .WithMany(p => p.UsuarioPermisoUsuarioIdAsignacionNavigation)
                    .HasForeignKey(d => d.UsuarioIdAsignacion)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioPermiso_Usuario1");
            });

            modelBuilder.Entity<UsuarioSucursalCaja>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.SucursalCajaId })
                    .HasName("PK_UsuarioSucursalCaja");

                entity.HasOne(d => d.SucursalCaja)
                    .WithMany(p => p.UsuarioSucursalCaja)
                    .HasForeignKey(d => d.SucursalCajaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioSucursalCaja_SucursalCaja");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioSucursalCaja)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioSucursalCaja_Usuario");
            });

            modelBuilder.Entity<UsuarioTipo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(100)");
            });

            modelBuilder.Entity<UsuarioTipoPagoConcepto>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioTipoId, e.PagoConceptoId, e.OfertaEducativaId })
                    .HasName("PK_UsuarioTipoPagoConcepto");

                entity.Property(e => e.FechaAsignacion).HasColumnType("date");

                entity.Property(e => e.HoraAsignacion).HasColumnType("time(0)");

                entity.HasOne(d => d.UsuarioIdAsignacionNavigation)
                    .WithMany(p => p.UsuarioTipoPagoConcepto)
                    .HasForeignKey(d => d.UsuarioIdAsignacion)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioTipoPagoConcepto_Usuario");

                entity.HasOne(d => d.UsuarioTipo)
                    .WithMany(p => p.UsuarioTipoPagoConcepto)
                    .HasForeignKey(d => d.UsuarioTipoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioTipoPagoConcepto_UsuarioTipo");

                entity.HasOne(d => d.PagoConcepto)
                    .WithMany(p => p.UsuarioTipoPagoConcepto)
                    .HasForeignKey(d => new { d.PagoConceptoId, d.OfertaEducativaId })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UsuarioTipoPagoConcepto_PagoConcepto");
            });
        }
    }
}