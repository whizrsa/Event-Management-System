using Microsoft.AspNetCore.Identity;

namespace Event_Management_System.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;

        public ICollection<RSVP> RSVPs { get; set; }
        public ICollection<Event> OrganizedEvents { get; set; }
    }
}
