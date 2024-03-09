using AutentificacionUsuarios.Data;
using AutentificacionUsuarios.Services.Interfaces;

namespace AutentificacionUsuarios.Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly YourDbContext _context;
    }
}
