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
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();

            // Post Mapper Profile
            CreateMap<Post, PostDto>()
                .IncludeMembers(post => post.User, post => post.Tags);
            CreateMap<User, PostDto>(MemberList.None);
            CreateMap<ICollection<Tag>, PostDto>(MemberList.None);
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();

            // Tag Mapper Profile
            CreateMap<Tag, TagDto>();
        }
    }
}
