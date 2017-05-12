using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoAntecedente
    {
        public int AlumnoId { get; set; }
        public int AntecedenteTipoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int AreaAcademicaId { get; set; }
        public string Procedencia { get; set; }
        public decimal Promedio { get; set; }
        public int Anio { get; set; }
        public int MesId { get; set; }
        public bool EsEquivalencia { get; set; }
        public string EscuelaEquivalencia { get; set; }
        public int PaisId { get; set; }
        public int EntidadFederativaId { get; set; }
        public bool EsTitulado { get; set; }
        public string TitulacionMedio { get; set; }
        public int MedioDifusionId { get; set; }
        public int UsuarioId { get; set; }

        public virtual Alumno Alumno { get; set; }
        public virtual AntecedenteTipo AntecedenteTipo { get; set; }
        public virtual AreaAcademica AreaAcademica { get; set; }
        public virtual EntidadFederativa EntidadFederativa { get; set; }
        public virtual MedioDifusion MedioDifusion { get; set; }
        public virtual Mes Mes { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
