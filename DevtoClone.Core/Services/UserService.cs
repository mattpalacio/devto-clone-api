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
        private readonly ILogger<UserService> _logger;
        private readonly IUnitOfWork _unitOfWork;

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

        public async Task<User> GetUserById(Guid id)
        {
            try
            {
                var user = await _unitOfWork.Users.GetUserByIdWithPostsAsync(id);

                if (user is null)
                {
                    throw new ArgumentNullException(nameof(user));
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> GetUserByEmail(string email)
        {
            try
            {
                var user = await _unitOfWork.Users.GetUserByEmailWithPostsAsync(email);

                if (user is null)
                {
                    throw new ArgumentNullException(nameof(user));
                }

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task CreateUser(User user)
        {
            try
            {
                _unitOfWork.Users.Add(user);

                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateUser(Guid id, User user)
        {
            try
            {
                var existingUser = await _unitOfWork.Users.GetByIdAsync(id);

                if(existingUser is null)
                {
                    throw new ArgumentNullException(nameof(existingUser));
                }

                existingUser.Username = user.Username;
                existingUser.Email = user.Email;

                _unitOfWork.Users.Update(existingUser);

                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteUser(Guid id)
        {
            try
            {
                _unitOfWork.Users.Delete(id);

                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
