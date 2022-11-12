using DevtoClone.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DevtoClone.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Tag>? Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed User table
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Username = "matt",
                        Email = "matt@email.com"
                    },
                    new User
                    {
                        Username = "patrick",
                        Email = "patrick@email.com"
                    },
                    new User
                    {
                        Username = "anne",
                        Email = "anne@email.com"
                    }
                );

            // Seed Tag Table
            modelBuilder.Entity<Tag>()
                .HasData(
                    new Tag
                    {
                        Name = "html"
                    },
                    new Tag
                    {
                        Name = "css"
                    },
                    new Tag
                    {
                        Name = "javascript"
                    }
                );
        }
    }
}