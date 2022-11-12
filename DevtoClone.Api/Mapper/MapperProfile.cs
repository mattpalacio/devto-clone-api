using AutoMapper;
using DevtoClone.Api.DTOs.User;
using DevtoClone.Entities.Models;

namespace DevtoClone.Api.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // User Profile
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}
