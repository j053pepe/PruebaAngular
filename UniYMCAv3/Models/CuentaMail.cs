using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class CuentaMail
    {
        public int CuentaMailId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Smtp { get; set; }
        public int Puerto { get; set; }
        public bool Ssl { get; set; }
        public string Descripcion { get; set; }
        public int EstatusId { get; set; }
    }
}
