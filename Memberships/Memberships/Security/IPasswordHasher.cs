namespace Memberships.Security
{
    public interface IPasswordHasher
    {
        string Hash(string password);
        bool Verify(string passwordHasg, string inputPassword);
    }
}
