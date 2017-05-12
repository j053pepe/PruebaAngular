using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoConcepto
    {
        public PagoConcepto()
        {
            AlumnoDescuento = new HashSet<AlumnoDescuento>();
            AlumnoReferenciaBitacora = new HashSet<AlumnoReferenciaBitacora>();
            Cuota = new HashSet<Cuota>();
            Descuento = new HashSet<Descuento>();
            UsuarioTipoPagoConcepto = new HashSet<UsuarioTipoPagoConcepto>();
        }

        public int PagoConceptoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public string Descripcion { get; set; }
        public string CuentaContable { get; set; }
        public bool EsTramite { get; set; }
        public bool EsVisible { get; set; }
        public bool EsVariable { get; set; }
        public bool EsMultireferencia { get; set; }
        public bool EsIva { get; set; }
        public bool EsCancelable { get; set; }
        public bool TieneDescripcion { get; set; }
        public string ClaveContable { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<AlumnoDescuento> AlumnoDescuento { get; set; }
        public virtual ICollection<AlumnoReferenciaBitacora> AlumnoReferenciaBitacora { get; set; }
        public virtual ICollection<Cuota> Cuota { get; set; }
        public virtual ICollection<Descuento> Descuento { get; set; }
        public virtual ICollection<UsuarioTipoPagoConcepto> UsuarioTipoPagoConcepto { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
    }
}
