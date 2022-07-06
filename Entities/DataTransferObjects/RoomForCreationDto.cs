
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class RoomForCreationDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }

    }
}
