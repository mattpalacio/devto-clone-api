using DevtoClone.Entities.Models;
using DevtoClone.Entities;
using DevtoClone.Repository.Interface;

namespace DevtoClone.Repository.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
