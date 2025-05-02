using Event_Management_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Event>()
                .HasOne(e => e.Organizer)
                .WithMany(u => u.OrganizedEvents)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<RSVP>()
                .HasOne(r => r.User)
                .WithMany(u => u.RSVPs)
                .HasForeignKey(r => r.UserId);

            builder.Entity<RSVP>()
                .HasOne(r => r.Event)
                .WithMany(e => e.RSVPs)
                .HasForeignKey(r => r.EventId);
        }

    }
}
