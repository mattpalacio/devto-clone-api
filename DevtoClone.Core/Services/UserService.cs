using DevtoClone.Core.Interfaces;
using DevtoClone.Entities.Models;
using DevtoClone.Entities.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevtoClone.Core.Services
{
    public class UserService : IUserService
    {
        private ILogger<UserService> _logger;
        private IUnitOfWork _unitOfWork;

        public UserService(ILogger<UserService> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            try
            {
                var users = await _unitOfWork.Users.GetAsync();

                if (users is null)
                {
                    throw new ArgumentNullException(nameof(users));
                }

                return users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<User> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(Guid id, User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
