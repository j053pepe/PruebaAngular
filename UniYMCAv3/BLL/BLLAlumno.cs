using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniYMCAv3.Models;

namespace UniYMCAv3.BLL
{
    public class BLLAlumno
    {
        public static async Task<List<DTOAlumnoLigero>> ListaAlumnos(Universidad_wContext _db)
        {

            var inscrito =await (from b in _db.AlumnoInscrito.AsNoTracking()
                            select new AlumnoInscrito
                            {
                                AlumnoId = b.AlumnoId,
                                OfertaEducativa = new OfertaEducativa
                                {
                                    Descripcion = b.OfertaEducativa.Descripcion
                                }
                            }).ToListAsync();
            var a2 = await
                (from a in _db.Alumno.AsNoTracking()
                 where a.EstatusId != 3
                 //where a.FechaRegistro.Year >= DateTime.Now.Year - 7
                 select new Alumno
                 {
                     AlumnoId = a.AlumnoId,
                     Nombre = a.Nombre + " " + a.Paterno + " " + a.Materno,
                     FechaRegistro = a.FechaRegistro,
                     Usuario = new Usuario { Nombre = a.Usuario.Nombre },
                     AlumnoInscrito = inscrito.Where(b => b.AlumnoId == a.AlumnoId).ToList()
                 }).ToListAsync();

            var alumn =
               ((from a in a2
                 select new DTOAlumnoLigero
                 {
                     AlumnoId = a.AlumnoId,
                     Nombre = a.Nombre + " " + a.Paterno + " " + a.Materno,
                     FechaRegistro = a.FechaRegistro.ToString(),
                     Usuario = a.Usuario.Nombre,
                     OfertasEducativas = a.AlumnoInscrito.Count > 0 ? a.AlumnoInscrito
                                       .Select(AI => AI.OfertaEducativa?.Descripcion ?? "")
                                       .ToList() : null,
                 })).ToList();
            return alumn;
        }
    }
}
