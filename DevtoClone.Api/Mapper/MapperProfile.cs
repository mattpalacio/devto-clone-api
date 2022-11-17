using AutoMapper;
using DevtoClone.Api.DTOs.Post;
using DevtoClone.Api.DTOs.Tag;
using DevtoClone.Api.DTOs.User;
using DevtoClone.Entities.Models;
using Microsoft.IdentityModel.Tokens;

namespace DevtoClone.Api.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // User Mapper Profile
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Posts, opts => opts.Condition(src => !src.Posts.IsNullOrEmpty()));
            CreateMap<ICollection<Post>, UserDto>(MemberList.None);
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();

            // Post Mapper Profile
            CreateMap<Post, PostDto>()
                .ForPath(dest => dest.Author.AuthorId, opts => opts.MapFrom(src => src.UserId))
                .ForPath(dest => dest.Author.Name, opts => opts.MapFrom(src => src.User.Username));
            CreateMap<ICollection<Tag>, PostDto>(MemberList.None);
            CreateMap<CreatePostDto, Post>();
            CreateMap<UpdatePostDto, Post>();

            // Tag Mapper Profile
            CreateMap<Tag, TagDto>();
        }
    }
}
