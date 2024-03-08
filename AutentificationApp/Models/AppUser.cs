using Microsoft.AspNetCore.Identity;

namespace AutentificationApp.Models
{
    public class AppUser : IdentityUser
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
    }
}
