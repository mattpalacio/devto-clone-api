using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevtoClone.Entities.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Tag
    {
        [Key]
        [Column("TagId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(100, ErrorMessage = "Length must be less than 100 characters.")]
        public string Name { get; set; } = null!;

        public ICollection<Post> Posts { get; set; } = null!;
    }
}
