using DevtoClone.Repository.Interface;
using DevtoClone.Repository.Repositories;

namespace DevtoClone.Entities.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private RepositoryContext _context;
        public IUserRepository Users { get; set; }
        public IPostRepository Posts { get; set; }
        public ITagRepository Tags { get; set; }

        public UnitOfWork(RepositoryContext context)
        {
            _context = context;

            Users = new UserRepository(context);
            Posts = new PostRepository(context);
            Tags = new TagRepository(context);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

// Reference: https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application#creating-the-unit-of-work-class