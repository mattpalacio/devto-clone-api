using System.Collections.ObjectModel;
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
        public string Title { get; set; } = null!;

        public string Content { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public virtual ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
    }
}
