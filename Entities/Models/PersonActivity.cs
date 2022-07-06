using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("personactivity")]
    public class PersonActivity
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        public Person? Person { get; set; }

        [ForeignKey(nameof(Activity))]
        public Guid ActivityId { get; set; }
        public Activity? Activity { get; set; }
    }
}
