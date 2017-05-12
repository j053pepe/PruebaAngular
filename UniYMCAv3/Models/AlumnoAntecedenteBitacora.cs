using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class AlumnoAntecedenteBitacora
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
        public int UsuarioIdBitacora { get; set; }
        public DateTime FechaBitacora { get; set; }
        public TimeSpan HoraBitacora { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
