using DevtoClone.Entities.Models;

namespace DevtoClone.Core.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User> GetUserById(Guid id);
        public Task CreateUser(User user);
        public Task UpdateUser(Guid id, User user);
        public Task DeleteUser(Guid id);
    }
}
