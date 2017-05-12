using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO
{
    public class DTOReciboDatos
    {

        public DTOReciboDatos()
        {
            fechaGeneracion = DateTime.Now;
            sfecha = fechaGeneracion.ToString("dd/MM/YYYY");
        }

        public string alumno { get; set; }
        public string ofertaEducativa { get; set; }
        public string reciboId { get; set; }
        public DateTime fechaGeneracion { get; set; }
        //Mascara para reporte
        public string sfecha { get; set; }
        public TimeSpan horaGeneracion { get; set; }
        public string importeLetra { get; set; }
        public decimal total { get; set; }
        public string observaciones { get; set; }
        public string cajero { get; set; }
        public string anuncio { get; set; }
    }
}
