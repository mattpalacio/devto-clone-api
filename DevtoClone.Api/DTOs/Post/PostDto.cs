using DevtoClone.Api.DTOs.Tag;
using DevtoClone.Api.DTOs.User;

namespace DevtoClone.Api.DTOs.Post
{
    public class PostDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public UserDto? User { get; set; }
        public IEnumerable<TagDto> Tags { get; set; } = null!;
    }
}
