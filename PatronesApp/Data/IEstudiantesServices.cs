using PatronesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronesApp.Data
{
    public interface IEstudiantesServices
    {
        Task<bool> DeleteEstudiante(int id);
        Task<IEnumerable<Estudiantes>> GetAllEstudiantes();
        Task<Estudiantes> GetEstudianteDetails(int id);
        Task<bool> InsertEstudiante(Estudiantes estudiante);
        Task<bool> UpdateEstudiante(Estudiantes estudiante);
        Task<bool> SaveEstudiante(Estudiantes estudiante);


    }
}
