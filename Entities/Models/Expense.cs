using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("expense")]
    public class Expense
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Expense Detail is required")]
        [StringLength(60, ErrorMessage = "Expense Detail cannot be longer than 60 characters")]
        public string? ExpenseDetail { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public int Amount { get; set; }

        [ForeignKey(nameof(Activity))]
        public Guid ActivityId { get; set; }
        public Activity? Activity { get; set; }
    }
}
