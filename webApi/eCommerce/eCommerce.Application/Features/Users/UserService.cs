using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce.Domain.Features.Users;

namespace eCommerce.Application.Features.Users;

public class UserService : IUserService
{
    public async Task<User> CreateAsync(User user)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(string userName, string password)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(string userName)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    public async Task<User?> GetByIdAsync(string userName)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}