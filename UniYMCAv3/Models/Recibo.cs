using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Recibo
    {
        public Recibo()
        {
            PagoParcial = new HashSet<PagoParcial>();
            ReciboArchivo = new HashSet<ReciboArchivo>();
        }

        public int ReciboId { get; set; }
        public int SucursalCajaId { get; set; }
        public string Observaciones { get; set; }
        public decimal Importe { get; set; }
        public int AlumnoId { get; set; }
        public int OfertaEducativaId { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public TimeSpan HoraGeneracion { get; set; }
        public int UsuarioId { get; set; }
        public int EstatusId { get; set; }

        public virtual ICollection<PagoParcial> PagoParcial { get; set; }
        public virtual ICollection<ReciboArchivo> ReciboArchivo { get; set; }
        public virtual ReciboDetalle ReciboDetalle { get; set; }
        public virtual ReciboMsi ReciboMsi { get; set; }
        public virtual Alumno Alumno { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual SucursalCaja SucursalCaja { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
