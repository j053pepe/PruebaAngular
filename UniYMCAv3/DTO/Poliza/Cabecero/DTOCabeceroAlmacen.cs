﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO
{
    public class DTOCabeceroAlmacen
    {
        public string descripcion { get; set; }
        public string valorDefault { get; set; }
        public int longitud { get; set; }
        public bool tieneEspacio { get; set; }
    }
}
