using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniYMCAv3.Models;
using DTO;

namespace UniYMCAv3.Controllers
{
    [Produces("application/json")]
    [Route("api/Alumno")]
    public class AlumnoController : Controller
    {
        private readonly Universidad_wContext _db;
        public AlumnoController(Universidad_wContext db) { _db = db; }

        [HttpGet]
        public async Task<IActionResult> GetAlumnos()
        {
            //List<DTOAlumnoLigero> lstAlumno = await BLL.BLLAlumno.ListaAlumnos(_db);
            List<DTOAlumnoLigero> lstAlumnos = await BLL.BLLAlumno.ListaAlumnos(_db);
            return Ok(lstAlumnos);
        }
    }
}