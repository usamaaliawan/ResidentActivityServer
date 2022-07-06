﻿using Entities.Models;

namespace Contracts
{
    public interface IRoomRepository : IRepositoryBase<Room>
    {
        IEnumerable<Room> GetAllRooms();
        Room GetRoomById(Guid roomId);

        Room GetRoomWithDetails(Guid roomId);

        void CreateRoom(Room room);

        void UpdateRoom(Room room);

        void DeleteRoom(Room room);
    }
}
