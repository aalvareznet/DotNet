using DatosEscuela;
using DatosEscuela.Entidades;
using EscuelaAPI.DTOs.Materias;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscuelaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private ContextoEscuela _context;

        public MateriaController(ContextoEscuela context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<MateriasDto>> Get() =>
            await _context.Materias.Select(m => new MateriasDto 
            {
                Id = m.Id,
                Nombre = m.Nombre,
                Especialidad = m.Especialidad
            }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<MateriasDto>> GetById(int id) 
        {
            var materia = await _context.Materias.FindAsync(id);

            if (materia == null) 
            {
                return NotFound();
            }

            var materiaDto = new MateriasDto
            {
                Id=materia.Id,
                Nombre=materia.Nombre,
                Especialidad=materia.Especialidad
            };

            return Ok(materiaDto);
        }
        [HttpPost]
        public async Task<ActionResult<MateriasDto>> Add(InsertarMateriaDto materiaDto) 
        {
            var materia = new Materias()
            {
                Nombre = materiaDto.Nombre,
                Especialidad = materiaDto.Especialidad
            };
            await _context.Materias.AddAsync(materia);
            await _context.SaveChangesAsync();

            var respuestaDto = new MateriasDto
            {
                Id = materia.Id,
                Nombre = materia.Nombre,
                Especialidad = materia.Especialidad
            };

            return CreatedAtAction(nameof(GetById), new { id = materia.Id }, respuestaDto);
        }
        [HttpPut]
        public async Task<ActionResult<MateriasDto>> Update(int id, EditarMateriasDto editarMaterias) 
        {
            var materia = await _context.Materias.FindAsync(id);

            if(materia == null) 
            {
                return NotFound();
            }

            materia.Nombre = editarMaterias.Nombre;
            materia.Especialidad = editarMaterias.Especialidad;
            await _context.SaveChangesAsync();

            var respuestaDto = new MateriasDto
            {
                Id = materia.Id,
                Nombre = materia.Nombre,
                Especialidad = materia.Especialidad
            };
            return Ok(respuestaDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delege(int id) 
        {
            var materia = await _context.Materias.FindAsync(id);

            if(materia == null) 
            {
                return NotFound();
            }
            
            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();

            return Ok();
        }

        

    }
}
