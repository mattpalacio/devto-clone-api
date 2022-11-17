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
        public Author Author { get; set; } = null!;
        public IEnumerable<TagDto> Tags { get; set; } = null!;
    }

    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; } = null!;
    }
}
