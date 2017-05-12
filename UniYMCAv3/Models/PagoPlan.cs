using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoPlan
    {
        public PagoPlan()
        {
            AlumnoInscrito = new HashSet<AlumnoInscrito>();
            AlumnoInscritoBitacora = new HashSet<AlumnoInscritoBitacora>();
            GrupoAlumnoConfiguracion = new HashSet<GrupoAlumnoConfiguracion>();
            GrupoAlumnoConfiguracionBitacora = new HashSet<GrupoAlumnoConfiguracionBitacora>();
            OfertaEducativaAntecedente = new HashSet<OfertaEducativaAntecedente>();
            OfertaEducativaPlan = new HashSet<OfertaEducativaPlan>();
        }

        public int PagoPlanId { get; set; }
        public string PlanPago { get; set; }
        public string Descripcion { get; set; }
        public int Pagos { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<AlumnoInscrito> AlumnoInscrito { get; set; }
        public virtual ICollection<AlumnoInscritoBitacora> AlumnoInscritoBitacora { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracion> GrupoAlumnoConfiguracion { get; set; }
        public virtual ICollection<GrupoAlumnoConfiguracionBitacora> GrupoAlumnoConfiguracionBitacora { get; set; }
        public virtual ICollection<OfertaEducativaAntecedente> OfertaEducativaAntecedente { get; set; }
        public virtual ICollection<OfertaEducativaPlan> OfertaEducativaPlan { get; set; }
        public virtual Estatus Estatus { get; set; }
    }
}
