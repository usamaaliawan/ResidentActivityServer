using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("activity")]
    public class Activity
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Activity Title is required")]
        [StringLength(60, ErrorMessage = "Activity Title cannot be longer than 60 characters")]
        public string? ActivityTitle { get; set; }

        [Required(ErrorMessage = "Activity Leader is required")]
        [StringLength(60, ErrorMessage = "Activity Leader cannot be longer than 60 characters")]
        public string? ActivityLeader { get; set; }

        public ICollection<PersonActivity>? PersonActivities { get; set; }

        public ICollection<Expense>? Expenses { get; set; }
    }
}
