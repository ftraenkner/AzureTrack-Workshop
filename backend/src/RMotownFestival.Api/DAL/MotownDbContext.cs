using Microsoft.EntityFrameworkCore;

using RMotownFestival.Api.Domain;
using RMotownFestival.Api.Migrations.Seeders;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext : DbContext
    {
        public MotownDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }
        public DbSet<Stage> Stages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DummyDataSeeder.Seed(modelBuilder);
        }
    }
}
