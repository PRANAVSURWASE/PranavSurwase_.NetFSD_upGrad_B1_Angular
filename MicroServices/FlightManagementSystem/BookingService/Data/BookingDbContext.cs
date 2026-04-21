using BookingService.Model;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Data
{
    public class BookingDbContext:DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options)
        {
        }
        public DbSet<Booking>bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Booking>(entity =>
            {
                // Primary Key
                entity.HasKey(b => b.Id);

                // Passenger Name (Required + Length)
                entity.Property(b => b.PassengerName)
                      .IsRequired()
                      .HasMaxLength(100);

                // FlightId (Required)
                entity.Property(b => b.FlightId)
                      .IsRequired();

                // BookingDate (Default value)
                entity.Property(b => b.BookingDate)
                      .HasDefaultValueSql("GETDATE()");
            });
        }


    }
}
