using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatronesApp.Models
{
    public class Estudiantes
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Edad { get; set; }
        public string CursosAsignados { get; set; }
        public string JornadaClases { get; set; }
        public DateTime Ts { get; set; }
    }
}
