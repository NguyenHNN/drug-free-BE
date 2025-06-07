using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Services.Interfaces;

namespace Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<UserAccount> _userRepository;

        public UserService(IGenericRepository<UserAccount> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserAccount> GetByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<UserAccount>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<UserAccount> CreateAsync(UserAccount user)
        {
            await _userRepository.AddAsync(user);
            return user;
        }

        public async Task UpdateAsync(UserAccount user)
        {
            _userRepository.Update(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user != null)
            {
                _userRepository.Remove(user);
            }
        }

        public async Task<UserAccount> GetByEmailAsync(string email)
        {
            var users = await _userRepository.FindAsync(u => u.Email == email);
            return users.FirstOrDefault();
        }

        public async Task<UserAccount> GetByUsernameAsync(string username)
        {
            var users = await _userRepository.FindAsync(u => u.Fullname == username);
            return users.FirstOrDefault();
        }
    }
} 