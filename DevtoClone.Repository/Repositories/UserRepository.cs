using DevtoClone.Entities.Models;
using DevtoClone.Entities;
using DevtoClone.Repository.Interface;

namespace DevtoClone.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
