using DevtoClone.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Repository.Interface
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User> GetUserByIdWithPostsAsync(Guid id);
        public Task<User> GetUserByEmailWithPostsAsync(string email);
    }
}
