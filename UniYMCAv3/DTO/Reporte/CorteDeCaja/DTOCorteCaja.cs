using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO
{
    public class DTOCorteCaja
    {
        public List<DTOCorteCajaConcepto> Concepto { get; set; }
        public List<DTOCorteCajaTotal> Total { get; set; }
        public List<DTO.Reporte.CorteDeCaja.DTOFirmas> Firma { get; set; }
    }
}
