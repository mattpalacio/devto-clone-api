using DevtoClone.Entities;
using DevtoClone.Entities.Models;
using DevtoClone.Repository.Interface;

namespace DevtoClone.Repository.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
