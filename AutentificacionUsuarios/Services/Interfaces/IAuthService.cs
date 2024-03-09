namespace AutentificacionUsuarios.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(string email, string username, string password, string name);

    }
}
