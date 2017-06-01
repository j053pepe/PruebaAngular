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
    [Route("api/AltaDocente")]
    public class AltaDocenteController : Controller
    {
        private readonly UniversidadContext _db;
        public AltaDocenteController(UniversidadContext db) { _db = db; }

       
    }
}