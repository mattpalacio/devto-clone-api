using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevtoClone.Entities.Models
{
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        [Column("UserId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime JoinedDate { get; set; } = DateTime.UtcNow;

        [MaxLength(100, ErrorMessage = "Length must be less than 100 characters.")]
        public string Username { get; set; } = null!;

        [EmailAddress(ErrorMessage = "Must be a valid email format.")]
        public string Email { get; set; } = null!;

        [InverseProperty("User")]
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
