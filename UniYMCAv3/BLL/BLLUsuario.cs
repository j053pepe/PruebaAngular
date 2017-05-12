using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniYMCAv3.Models;

namespace UniYMCAv3.BLL
{
    public class BLLUsuario
    {
        public static async Task<List<Usuario>> Usuarios(Universidad_wContext db)
        {
            return db.Usuario.ToList();
        }
    }
}
