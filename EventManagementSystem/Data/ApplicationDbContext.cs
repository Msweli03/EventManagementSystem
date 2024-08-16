using EventManagementSystem.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Ensure a user can only register once per event
        //    modelBuilder.Entity<Registration>()
        //        .HasIndex(r => new { r.UserId, r.EventId })
        //        .IsUnique();

        //    // Seed some initial data
        //    modelBuilder.Entity<Event>().HasData(
        //        new Event { Id = 1, Name = "Tech Conference", Date = DateTime.Now.AddMonths(1), TotalSeats = 100, AvailableSeats = 100 },
        //        new Event { Id = 2, Name = "Music Festival", Date = DateTime.Now.AddMonths(2), TotalSeats = 200, AvailableSeats = 200 }
        //    );
        //}
    }
}
