using DevtoClone.Api.DTOs.Post;

namespace DevtoClone.Api.DTOs.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public DateTime JoinedDate { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public IEnumerable<PostDto> Posts { get; set; } = null!;
    }
}
