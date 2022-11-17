using DevtoClone.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Repository.Interface
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        public Task<IEnumerable<Post>> GetAllPosts();
    }
}
