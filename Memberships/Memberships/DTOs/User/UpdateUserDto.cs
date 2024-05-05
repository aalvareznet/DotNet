namespace Memberships.DTOs.User
{
    public class UpdateUserDto
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? PasswordHash { get; set; }
    }
}
