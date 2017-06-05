using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO
{
    public class DTOCatalogos
    {
        public DTOCatalogos()
        {
            Paises = new List<DTOPais>();
            Entidades = new List<DTOEntidadFederativa>();
            Generos = new List<DTOGenero>();
            EstadosCiviles = new List<DTOEstadoCivil>();
        }
        public List<DTOPais> Paises { get; set; }
        public List<DTOEntidadFederativa> Entidades { get; set; }
        public List<DTOGenero> Generos { get; set; }
        public List<DTOEstadoCivil> EstadosCiviles { get; set; }
    }

    public class DTOPais
    {
        public int PaisId { get; set; }
        public string Descripcion { get; set; }

        public string value { get; set; }
        public string label { get; set; }
    }

    public class DTOEntidadFederativa
    {
        public int EntidadFederativaId { get; set; }
        public string Descripcion { get; set; } 

        public string value { get; set; }
        public string label { get; set; }
    }

    public class DTOMunicipio
    {
        public int MunicipioId { get; set; }
        public string Descripcion { get; set; }
        public string EntidadFederativaId { get; set; }

        public string value { get; set; }
        public string label { get; set; }
    }

    public class DTOGenero
    {
        public int GeneroId { get; set; }
        public string Descripcion { get; set; }

        public string value { get; set; }
        public string label { get; set; }
    }

    public class DTOEstadoCivil
    {
        public int EstadoCivilId { get; set; }
        public string Descripcion { get; set; }

        public string value { get; set; }
        public string label { get; set; }
    }




}
