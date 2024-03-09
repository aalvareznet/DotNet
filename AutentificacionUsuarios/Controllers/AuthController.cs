using AutentificacionUsuarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutentificacionUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            // Implementa la lógica de registro
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            // Aquí puedes implementar la lógica para autenticar a los usuarios
            // Por ejemplo, verificar las credenciales, generar y devolver un token JWT, etc.
            // Retorna un IActionResult apropiado (por ejemplo, Ok con el token JWT si el inicio de sesión es exitoso, BadRequest si hay errores, etc.)
        }
    }
}
