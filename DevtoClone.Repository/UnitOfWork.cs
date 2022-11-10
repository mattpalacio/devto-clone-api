

using DevtoClone.Entities;
using DevtoClone.Entities.Models;
using DevtoClone.Repository.Repositories;

namespace DevtoClone.Repository
{
    public class UnitOfWork : IDisposable
    {
        private RepositoryContext context = new();
        private GenericRepository<User>? userRepository;
        private GenericRepository<Post>? postRepository;
        private GenericRepository<Tag>? tagRepository;

        public GenericRepository<User> UserRepository
        {
            get
            {
                this.userRepository ??= new GenericRepository<User>(context);
                return userRepository;
            }
        }

        public GenericRepository<Post> PostRepository
        {
            get
            {
                this.postRepository ??= new GenericRepository<Post>(context);
                return postRepository;
            }
        }

        public GenericRepository<Tag> TagRepository
        {
            get
            {
                this.tagRepository ??= new GenericRepository<Tag>(context);
                return tagRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

// Reference: https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application#creating-the-unit-of-work-class