using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Entities.Models
{
    public class Tag
    {
        [Key]
        [Column("TagId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(100, ErrorMessage = "Length must be less than 100 characters.")]
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; } = null!;

        public Tag(string name)
        {
            Name = name;
        }
    }
}
