using DevtoClone.Entities.Models;
using DevtoClone.Entities;
using DevtoClone.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DevtoClone.Repository.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Post>> GetAllPosts()
        {
            var posts = await _context.Posts
                .Include(p => p.User)
                .Include(p => p.Tags)
                .AsNoTracking()
                .ToListAsync();

            return posts;
        }
    }
}
