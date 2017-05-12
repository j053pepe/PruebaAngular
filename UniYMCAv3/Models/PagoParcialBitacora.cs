using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class PagoParcialBitacora
    {
        public int PagoParcialId { get; set; }
        public int PagoId { get; set; }
        public int? SucursalCajaId { get; set; }
        public int? ReciboId { get; set; }
        public decimal Pago { get; set; }
        public DateTime FechaPago { get; set; }
        public TimeSpan HoraPago { get; set; }
        public int EstatusId { get; set; }
        public bool TieneMovimientos { get; set; }
        public int PagoTipoId { get; set; }
        public int? ReferenciaProcesadaId { get; set; }
        public DateTime FechaBitacora { get; set; }
        public TimeSpan HoraBitacora { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
