using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("room")]
    public class Room
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }

        public ICollection<Person>? Persons { get; set; }
    }
}
