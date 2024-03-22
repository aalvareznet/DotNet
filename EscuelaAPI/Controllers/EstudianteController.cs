using DatosEscuela;
using EscuelaAPI.DTOs.Estudiantes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscuelaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private ContextoEscuela _context;

        public EstudianteController(ContextoEscuela context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IEnumerable<EstudiantesDto>> Get() =>
            await _context.Estudiantes.Select(e => new EstudiantesDto
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Apellido1 = e.Apellido1,
                Apellido2 = e.Apellido2,
                Grado = e.Grado,
                Seccion = e.Seccion,
                ProfesorGuiaId = e.ProfesorGuiaID
            }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<EstudiantesDto>> GetById(int id) 
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null) 
            {
                return NotFound();
            }

            var estudianteDto = new EstudiantesDto
            {
                Id = estudiante.Id,
                Nombre = estudiante.Nombre,
                Apellido1 = estudiante.Apellido1,
                Apellido2 = estudiante.Apellido2,
                Grado = estudiante.Grado,
                Seccion = estudiante.Seccion,
                ProfesorGuiaId = estudiante.ProfesorGuiaID
            };

            return Ok(estudianteDto);
        }
    }
}
