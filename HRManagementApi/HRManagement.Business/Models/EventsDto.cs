
namespace HRManagement.Business.Models
{
   public class EventsDto
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public LocationType Location { get; set; }

        public EventType Type { get; set; }
    }

    public enum EventType
    {
        General,
        Personal
    }

    public enum LocationType
    {
        Online,
        Remote
    }
}
