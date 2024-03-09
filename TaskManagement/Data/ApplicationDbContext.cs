using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
