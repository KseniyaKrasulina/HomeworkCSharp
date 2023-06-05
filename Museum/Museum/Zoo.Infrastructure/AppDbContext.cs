using Microsoft.EntityFrameworkCore;
using Museum.Entities;

namespace Museum.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Exhibit> Exhibits { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Level_of_education> Levels_of_education { get; set; }
        public DbSet<Position_of_worker> Position_of_worker { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}