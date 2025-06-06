using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserAccount> GetByIdAsync(Guid id);
        Task<IEnumerable<UserAccount>> GetAllAsync();
        Task<UserAccount> CreateAsync(UserAccount user);
        Task UpdateAsync(UserAccount user);
        Task DeleteAsync(Guid id);
        Task<UserAccount> GetByEmailAsync(string email);
        Task<UserAccount> GetByUsernameAsync(string username);
    }
} 