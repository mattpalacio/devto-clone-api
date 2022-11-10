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
        public string Username { get; set; }

        public string Email { get; set; }

        // Note the following use of constructor binding, which avoids compiled warnings
        // for uninitialized non-nullable properties.
        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }
    }
}
