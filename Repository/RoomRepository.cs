using Entities.Models;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RoomRepository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return FindAll().ToList();
        }

        public Room GetRoomById(Guid Id)
        {
            return FindByCondition(room => room.Id.Equals(Id)).FirstOrDefault();
        }

        public Room GetRoomWithDetails(Guid roomId)
        {
            return FindByCondition(room => room.Id.Equals(roomId))
                .Include(ac => ac.Persons)
                .FirstOrDefault();
        }

        public void CreateRoom(Room room)
        {
            Create(room);
        }
        public void UpdateRoom(Room room)
        {
            Update(room);
        }

        public void DeleteRoom(Room room)
        {
            Delete(room);
        }
    }
}
