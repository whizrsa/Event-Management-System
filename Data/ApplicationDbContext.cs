using Event_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
    }
}
