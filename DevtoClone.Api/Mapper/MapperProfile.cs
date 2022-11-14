using AutoMapper;
using DevtoClone.Api.DTOs.Post;
using DevtoClone.Api.DTOs.Tag;
using DevtoClone.Api.DTOs.User;
using DevtoClone.Entities.Models;

namespace DevtoClone.Api.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // User Mapper Profile
            CreateMap<User, UserDto>();
            CreateMap<IEnumerable<User>, IEnumerable<UserDto>>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();

            // Tag Mapper Profile
            CreateMap<Tag, TagDto>();
            CreateMap<IEnumerable<Tag>, IEnumerable<TagDto>>();

            // Post Mapper Profile
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => (IEnumerable<Tag>)src.Tags)); // TODO: fix tags mapping
            CreateMap<IEnumerable<Post>, IEnumerable<PostDto>>();
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();

        }
    }
}
