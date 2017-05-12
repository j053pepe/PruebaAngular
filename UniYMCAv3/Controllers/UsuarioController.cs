using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniYMCAv3.Models;

namespace UniYMCAv3.Controllers
{
    [Produces("application/json")]
    [Route("api/Usuario")]
    public class UsuarioController : Controller
    {
        private readonly Universidad_wContext _db;
        public UsuarioController(Universidad_wContext db) { _db = db; }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            //List<DTOAlumnoLigero> lstAlumno = await BLL.BLLAlumno.ListaAlumnos(_db);
            List<Usuario> lstUsuario = await BLL.BLLUsuario.Usuarios(_db);
            return Ok(lstUsuario);
        }
    }
}