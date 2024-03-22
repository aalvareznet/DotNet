using DatosEscuela;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        
    }
}
