using Microsoft.EntityFrameworkCore;
using PatronesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronesApp.Data
{
    public class EstudiantesServices : IEstudiantesServices
    {
        private readonly UniversidadContext _context;

        public EstudiantesServices(UniversidadContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteEstudiante(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            _context.Estudiantes.Remove(estudiante);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Estudiantes>> GetAllEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        } 

        public async Task<Estudiantes> GetEstudianteDetails(int id)
        {
            return await _context.Estudiantes.FindAsync(id);
        }

        public async Task<bool> InsertEstudiante(Estudiantes estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateEstudiante(Estudiantes estudiante)
        {
            _context.Entry(estudiante).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveEstudiante(Estudiantes estudiante)
        {
            if (estudiante.IdEstudiante > 0)
                return await UpdateEstudiante(estudiante);
            else
                return await InsertEstudiante(estudiante);
        }

    }
}
