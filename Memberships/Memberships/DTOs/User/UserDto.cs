namespace Memberships.DTOs.User
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? PasswordHash { get; set; }
    }
}
