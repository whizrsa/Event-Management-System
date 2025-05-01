using Microsoft.AspNetCore.Identity;

namespace Event_Management_System.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }

    }
}
