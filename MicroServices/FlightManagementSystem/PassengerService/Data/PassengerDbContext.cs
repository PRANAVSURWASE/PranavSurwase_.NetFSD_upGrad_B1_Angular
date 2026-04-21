using Microsoft.EntityFrameworkCore;
using PassengerService.Model;

namespace PassengerService.Data
{
    public class PassengerDbContext:DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext>options):base(options)
        {

            
        }
        public DbSet<Passenger> Passengers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Passenger>().ToTable("Passengers");
        }

    }
}
