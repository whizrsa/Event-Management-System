namespace Event_Management_System.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string OrganizerId { get; set; }
        public virtual AppUser Organizer { get; set; }

        public virtual ICollection<RSVP> RSVPs { get; set; }
    }
}
