using DatosEscuela;
using DatosEscuela.Entidades;
using EscuelaAPI.DTOs.Profesores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscuelaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private ContextoEscuela _context;

        public ProfesorController(ContextoEscuela context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<ProfesoresDto>> Get() => await _context.Profesores.Select(e => new ProfesoresDto
        {
            Nombre = e.Nombre,
            Apellido1 = e.Apellido1,
            Apellido2 = e.Apellido2,
            MateriaId = e.MateriaId
        }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfesoresDto>> GetById(int id) 
        {
            var profesor = await _context.Profesores.FindAsync(id);

            if (profesor == null) 
            {
                return NotFound();
            }

            var profesorDto = new ProfesoresDto
            {
                Id = profesor.Id,
                Nombre = profesor.Nombre,
                Apellido1 = profesor.Apellido1,
                Apellido2 = profesor.Apellido2,
                MateriaId = profesor.MateriaId
            };
            return Ok(profesorDto);
        }

        [HttpPost]
        public async Task<ActionResult<ProfesoresDto>> Add(InsertarProfesoresDto profesorDto) 
        {
            var profesor = new Profesores()
            {
                Nombre = profesorDto.Nombre,
                Apellido1 = profesorDto.Apellido1,
                Apellido2 = profesorDto.Apellido2,
                MateriaId = profesorDto.MateriaId
            };

            await _context.Profesores.AddAsync(profesor);
            await _context.SaveChangesAsync();

            var respuestaDto = new ProfesoresDto
            {
                Id = profesor.Id,
                Nombre = profesor.Nombre,
                Apellido1 = profesor.Apellido1,
                Apellido2 = profesor.Apellido2,
                MateriaId = profesor.MateriaId
            };

            return CreatedAtAction(nameof(GetById), new { id = profesor.Id }, respuestaDto);
        }

        public async Task<ActionResult<ProfesoresDto>> Update(int id, EditarProfesoresDto editarProfesores) 
        {
            var profesor = await _context.Profesores.FindAsync(id);

            if (profesor == null) 
            {
                return NotFound();
            }

            profesor.Nombre = editarProfesores.Nombre;
            profesor.Apellido1 = editarProfesores.Apellido1;
            profesor.Apellido2 = editarProfesores.Apellido2;
            profesor.MateriaId = editarProfesores.MateriaId;

            await _context.SaveChangesAsync();

            var respuestaDto = new ProfesoresDto
            {
                Id = profesor.Id,
                Nombre = profesor.Nombre,
                Apellido1 = profesor.Apellido1,
                Apellido2 = profesor.Apellido2,
                MateriaId = profesor.MateriaId
            };
            return Ok(respuestaDto);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) 
        {
            var profesor = await _context.Profesores.FindAsync(id);

            if (profesor == null)
            {
                return NotFound();
            }
            _context.Profesores.Remove(profesor);
            await _context.SaveChangesAsync();

            return Ok();

        }
    
    }
}
