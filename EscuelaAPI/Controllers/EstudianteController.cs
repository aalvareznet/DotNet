using DatosEscuela;
using DatosEscuela.Entidades;
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
        [HttpPost]
        public async Task<ActionResult<EstudiantesDto>> Add(InsertarEstudianteDto estudianteDto) 
        {
            var estudiante = new Estudiantes()
            {
                Nombre = estudianteDto.Nombre,
                Apellido1 = estudianteDto.Apellido1,
                Apellido2 = estudianteDto.Apellido2,
                Grado = estudianteDto.Grado,
                Seccion = estudianteDto.Seccion,
                ProfesorGuiaID = estudianteDto.ProfesorGuiaId
            };
            await _context.Estudiantes.AddAsync(estudiante);
            await _context.SaveChangesAsync();

            var respuestaDto = new EstudiantesDto
            {
                Id = estudiante.Id,
                Nombre = estudiante.Nombre,
                Apellido1 = estudiante.Apellido1,
                Apellido2 = estudiante.Apellido2,
                Grado = estudiante.Grado,
                Seccion = estudiante.Seccion,
                ProfesorGuiaId = estudiante.ProfesorGuiaID
            };

            return CreatedAtAction(nameof(GetById), new { id = estudiante.Id }, respuestaDto);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<EstudiantesDto>> Update(int id, EditarEstudiantesDto editarEstudiantes) 
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null) 
            {
                return NotFound();
            }

            estudiante.Nombre = editarEstudiantes.Nombre;
            estudiante.Apellido1 = editarEstudiantes.Apellido1;
            estudiante.Apellido2 = editarEstudiantes.Apellido2;
            estudiante.Grado = editarEstudiantes.Grado;
            estudiante.Seccion = editarEstudiantes.Seccion;
            estudiante.ProfesorGuiaID = editarEstudiantes.ProfesorGuiaId;
            await _context.SaveChangesAsync();

            var respuestaDto = new EstudiantesDto
            {
                Id = estudiante.Id,
                Nombre = estudiante.Nombre,
                Apellido1 = estudiante.Apellido1,
                Apellido2 = estudiante.Apellido2,
                Grado = estudiante.Grado,
                Seccion = estudiante.Seccion,
                ProfesorGuiaId = estudiante.ProfesorGuiaID
            };
            return Ok(respuestaDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) 
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante == null)
            {
                return NotFound();
            }

            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
