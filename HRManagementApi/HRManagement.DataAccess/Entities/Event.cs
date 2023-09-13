
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRManagement.DataAccess.Entities
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public LocationType Location { get; set; }
        public EventType Type { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
        public long UserId { get; set; }

    }
    public enum LocationType
    {
        Online,
        Remote
    }
    public enum EventType
    {
        General,
        Personal
    }
}
