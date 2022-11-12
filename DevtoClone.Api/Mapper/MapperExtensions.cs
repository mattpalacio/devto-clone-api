using AutoMapper;
using DevtoClone.Api.DTOs.Post;
using DevtoClone.Api.DTOs.User;
using DevtoClone.Entities.Models;

namespace DevtoClone.Api.Mapper
{
    public static class MapperExtensions
    {
        public static IEnumerable<UserDto> MapUsers(this IMapper mapper, IEnumerable<User> users)
        {
            return users.Select(user => mapper.Map<UserDto>(user));
        }

        public static IEnumerable<PostDto> MapPosts(this IMapper mapper, IEnumerable<Post> posts)
        {
            return posts.Select(post => mapper.Map<PostDto>(post));
        }
    }
}
