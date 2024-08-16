using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Model
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public ICollection<Registration> Registrations { get; set; }

    }
}
