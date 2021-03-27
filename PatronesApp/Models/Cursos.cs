using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatronesApp.Models
{
    public class Cursos
    {
        [Key]
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public DateTime Ts { get; set; }
    }
}
