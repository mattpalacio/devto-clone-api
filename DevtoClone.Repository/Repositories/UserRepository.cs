using DevtoClone.Entities.Models;
using DevtoClone.Entities;
using DevtoClone.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DevtoClone.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public async Task<User> GetUserByIdWithPostsAsync(Guid id)
        {
            var user = await _context.Users
                .Include(p => p.Posts)
                .ThenInclude(p => p.Tags)
                .FirstAsync(u => u.Id == id);

            return user;
        }

        public async Task<User> GetUserByEmailWithPostsAsync(string email)
        {
            var user = await _context.Users
                .Include(p => p.Posts)
                .ThenInclude(p => p.Tags)
                .FirstAsync(u => u.Email == email);

            return user;
        }
    }
}
