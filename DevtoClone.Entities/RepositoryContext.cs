using DevtoClone.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DevtoClone.Entities
{
    public class RepositoryContext : DbContext
    {
        //public RepositoryContext(DbContextOptions options) : base(options)
        //{

        //}

        public DbSet<User>? Users { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Tag>? Tags { get; set; }
    }
}