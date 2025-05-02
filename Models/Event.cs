using System.ComponentModel.DataAnnotations;

namespace Event_Management_System.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [MaxLength(150)]
        public string ImageFileName { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        [MaxLength(150)]
        public string Location { get; set; } = string.Empty;
        public string OrganizerId { get; set; }
        public virtual AppUser Organizer { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }
    }
}
