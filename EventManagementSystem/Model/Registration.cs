using System.ComponentModel.DataAnnotations;

namespace EventManagementSystem.Model
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
