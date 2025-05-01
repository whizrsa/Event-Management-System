namespace Event_Management_System.Models
{
    public class RSVP
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public RSVPStatus Status { get; set; }
    }

    public enum RSVPStatus
    {
        Attending,
        NotAttending,
        Maybe
    }
}
