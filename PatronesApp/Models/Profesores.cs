using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatronesApp.Models
{
    public class Profesores
    {
        [Key]
        public int IdProfesor { get; set; }
        public string NombreProfesor { get; set; }
        public string ApellidoProfesor { get; set; }
        public string CursosDictados { get; set; }
        public string JornadaClases { get; set; }
        public DateTime Ts { get; set; }
    }
}
