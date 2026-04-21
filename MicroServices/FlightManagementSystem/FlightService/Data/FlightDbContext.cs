using FlightService.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightService.Data
{
    public class FlightDbContext:DbContext
    {
        public FlightDbContext(DbContextOptions<FlightDbContext> options):base(options)
        {


        }

        public DbSet<Flight> Flights { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>()
                .Property(f => f.Price)
                .HasPrecision(18, 2);
        }
    }
}
