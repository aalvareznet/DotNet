using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private AutenticacionUsuariosContext _context;

        public UsersController(AutenticacionUsuariosContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Usuarios> Get() => _context.Usuarios.ToList();
    }
}
