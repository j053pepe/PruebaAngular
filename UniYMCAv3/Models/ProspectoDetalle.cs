using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class ProspectoDetalle
    {
        public int ProspectoId { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Curp { get; set; }
        public int? GeneroId { get; set; }
        public int? EstadoCivilId { get; set; }
        public int? PaisId { get; set; }
        public int? EntidadFederativaId { get; set; }
        public int? MunicipioId { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string PrepaProcedencia { get; set; }
        public int? PrepaArea { get; set; }
        public int? PrepaAnio { get; set; }
        public int? PrepaMes { get; set; }
        public int? PrepaPaisId { get; set; }
        public decimal? PrepaPromedio { get; set; }
        public int? PrepaEntidadId { get; set; }
        public bool? EsEquivalencia { get; set; }
        public string UniversidadProcedencia { get; set; }
        public int? UniversidadPaisId { get; set; }
        public int? UniversidadEntidadId { get; set; }
        public string UniversidadMotivo { get; set; }
        public bool? EsTitulado { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public int? SucursalId { get; set; }
        public int? OfertaEducativaTipoId { get; set; }
        public int? OfertaEducativaId { get; set; }
        public int? TurnoId { get; set; }
        public int? MedioDifusionId { get; set; }
        public string Observaciones { get; set; }

        public virtual EntidadFederativa EntidadFederativa { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual MedioDifusion MedioDifusion { get; set; }
        public virtual OfertaEducativa OfertaEducativa { get; set; }
        public virtual OfertaEducativaTipo OfertaEducativaTipo { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual AreaAcademica PrepaAreaNavigation { get; set; }
        public virtual EntidadFederativa PrepaEntidad { get; set; }
        public virtual Pais PrepaPais { get; set; }
        public virtual Prospecto Prospecto { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Turno Turno { get; set; }
        public virtual EntidadFederativa UniversidadEntidad { get; set; }
        public virtual Pais UniversidadPais { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
