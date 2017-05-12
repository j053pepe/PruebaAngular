using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class OfertaEducativa
    {
        public OfertaEducativa()
        {
            Adeudo = new HashSet<Adeudo>();
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            AlumnoMovimiento = new HashSet<AlumnoMovimiento>();
            AlumnoReingresoBitacora = new HashSet<AlumnoReingresoBitacora>();
            AlumnoRevision = new HashSet<AlumnoRevision>();
            Asignatura = new HashSet<Asignatura>();
            BecaDeportiva = new HashSet<BecaDeportiva>();
            Cuota = new HashSet<Cuota>();
            Descuento = new HashSet<Descuento>();
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            IdiomaGrupoAlumno = new HashSet<IdiomaGrupoAlumno>();
            Matricula = new HashSet<Matricula>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            OfertaEducativaRequerimiento = new HashSet<OfertaEducativaRequerimiento>();
            Pago = new HashSet<Pago>();
            PagoConcepto = new HashSet<PagoConcepto>();
            PromocionCasa = new HashSet<PromocionCasa>();
            ProspectoDetalle = new HashSet<ProspectoDetalle>();
            Recibo = new HashSet<Recibo>();
            UniversidadValidacion = new HashSet<UniversidadValidacion>();
        }

        public int OfertaEducativaId { get; set; }
        public int OfertaEducativaTipoId { get; set; }
        public string Descripcion { get; set; }
        public string Rvoe { get; set; }
        public DateTime? FechaRvoe { get; set; }
        public int SucursalId { get; set; }
        public bool RequiereDeportivo { get; set; }
        public string ClaveContable { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<Adeudo> Adeudo { get; set; }
        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<AlumnoMovimiento> AlumnoMovimiento { get; set; }
        public virtual ICollection<AlumnoReingresoBitacora> AlumnoReingresoBitacora { get; set; }
        public virtual ICollection<AlumnoRevision> AlumnoRevision { get; set; }
        public virtual ICollection<Asignatura> Asignatura { get; set; }
        public virtual ICollection<BecaDeportiva> BecaDeportiva { get; set; }
        public virtual ICollection<Cuota> Cuota { get; set; }
        public virtual ICollection<Descuento> Descuento { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<IdiomaGrupoAlumno> IdiomaGrupoAlumno { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<OfertaEducativaRequerimiento> OfertaEducativaRequerimiento { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<PagoConcepto> PagoConcepto { get; set; }
        public virtual ICollection<PromocionCasa> PromocionCasa { get; set; }
        public virtual ICollection<ProspectoDetalle> ProspectoDetalle { get; set; }
        public virtual ICollection<Recibo> Recibo { get; set; }
        public virtual ICollection<UniversidadValidacion> UniversidadValidacion { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativaTipo OfertaEducativaTipo { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
