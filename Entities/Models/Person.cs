using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("person")]
    public class Person
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        public int Contact { get; set; }

        [ForeignKey(nameof(Room))]
        public Guid RoomId { get; set; }
        public Room? Room { get; set; }

        public ICollection<PersonActivity>? PersonActivities { get; set; }
    }
}
