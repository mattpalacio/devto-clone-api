using DevtoClone.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Core.Interfaces
{
    public interface IPostService
    {
        public Task<IEnumerable<Post>> GetAllPosts();
        public Task<Post> GetPostById(Guid id);
        public Task CreatePost(Post post, string[] tags);
        public Task UpdatePost(Guid id, Post post, string[] tags);
        public Task DeletePost(Guid id);
    }
}
