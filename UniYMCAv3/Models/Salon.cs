using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Salon
    {
        public int SalonId { get; set; }
        public string Descripcion { get; set; }
        public int? SedeId { get; set; }
        public int? Capacidad { get; set; }
        public string Detalle { get; set; }
    }
}
