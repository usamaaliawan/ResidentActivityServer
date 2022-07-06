using Entities.DataTransferObjects;
using Entities.Models;
using AutoMapper;

namespace ResidentActivityServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Room, RoomDto>();
            CreateMap<Person, PersonDto>();
            CreateMap<RoomForCreationDto, Room>();
            CreateMap<RoomForUpdateDto, Room>();
        }
    }
}
