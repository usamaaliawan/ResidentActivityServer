

namespace Entities.DataTransferObjects
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }

        public IEnumerable<PersonDto>? Perosns { get; set; }


    }
}
