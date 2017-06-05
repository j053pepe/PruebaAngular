using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniYMCAv3.Models;
using UniYMCAv3.DTO;

namespace UniYMCAv3.Controllers
{

    [Produces("application/json")]
    [Route("api/Catalogos")]
    public class CatalogosController : Controller
    {
        private readonly UniversidadContext _db;
        public CatalogosController(UniversidadContext db) { _db = db; }

        [HttpGet("altadocente")]
        public IActionResult AltaDocente()
        {

            List<DTOPais> pais = _db.Pais.Select(b => new DTOPais
            {
                PaisId = b.PaisId,
                Descripcion = b.Descripcion,
                value = b.PaisId.ToString(),
                label = b.Descripcion
            }).ToList();

            List<DTOEntidadFederativa> entidad = _db.EntidadFederativa.Where(a => a.SeMuestra == true)
                                                .Select(b => new DTOEntidadFederativa
                                                {
                                                    EntidadFederativaId = b.EntidadFederativaId,
                                                    Descripcion = b.Descripcion,
                                                    value = b.EntidadFederativaId.ToString(),
                                                    label = b.Descripcion
                                                }).ToList();

            List<DTOGenero> genero = _db.Genero.Select(b => new DTOGenero
            {
                GeneroId = b.GeneroId,
                Descripcion = b.Descripcion,
                value = b.GeneroId.ToString(),
                label = b.Descripcion
            }).ToList();

            List<DTOEstadoCivil> estadocivil = _db.EstadoCivil.Select(b => new DTOEstadoCivil
            {
                EstadoCivilId = b.EstadoCivilId,
                Descripcion = b.Descripcion,
                value = b.EstadoCivilId.ToString(),
                label = b.Descripcion
            }).ToList();
            
            DTOCatalogos catalogos = new DTOCatalogos();

            //seleccionar//
            catalogos.Paises.Add( new DTOPais
            {
                label = "--Seleccionar--",
                value = ""
            } );
            catalogos.Entidades.Add(new DTOEntidadFederativa
            {
                label = "--Seleccionar--",
                value = ""
            });
            catalogos.Generos.Add(new DTOGenero
            {
                label = "--Seleccionar--",
                value = ""
            });
            catalogos.EstadosCiviles.Add(new DTOEstadoCivil
            {
                label = "--Seleccionar--",
                value = ""
            });

            //Agregar catalogos//
            catalogos.Paises.AddRange(pais) ;
            catalogos.Entidades.AddRange(entidad);
            catalogos.Generos.AddRange(genero);
            catalogos.EstadosCiviles.AddRange(estadocivil);
            
            return Ok(catalogos);
        }

        [HttpGet("municipio/{estadoId}")]
        public IActionResult Municipio(int estadoId)
        {

            List<DTOMunicipio> municipio = new List<DTOMunicipio>();

            municipio.Add(new DTOMunicipio
            {
                label = "--Seleccionar--",
                value = ""
            }); 

            municipio.AddRange( _db.Municipio.Where(a => a.EntidadFederativaId == estadoId)
                                                        .Select(b => new DTOMunicipio
                                                        {
                                                            MunicipioId = b.MunicipioId,
                                                            Descripcion = b.Descripcion,
                                                            value = b.MunicipioId.ToString(),
                                                            label = b.Descripcion
                                                        }).ToList());



            return Ok(municipio);
        }
    }
}