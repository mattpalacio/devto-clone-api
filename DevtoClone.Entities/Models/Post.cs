using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DevtoClone.Entities.Models
{
    public class Post
    {
        [Key]
        [Column("PostId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [MaxLength(250, ErrorMessage = "Length must be less than 250 characters.")]
        public string Title { get; set; }

        public string Content { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Tag> Tags { get; set; } = null!;

        // Note the following use of constructor binding, which avoids compiled warnings
        // for uninitialized non-nullable properties.
        public Post(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
