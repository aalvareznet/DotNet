using Microsoft.EntityFrameworkCore;

namespace FishesApi.Models
{
    public class FishContext : DbContext
    {
        public FishContext(DbContextOptions<FishContext> options)
            : base(options)
        {
        }

        public DbSet<Fish> Fishes { get; set; }
        public DbSet<FishCategory> FishCategories { get; set; }
    }
}
