using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce.Domain.Features.Users;

namespace eCommerce.Application.Features.Users;

public class UserService
{
    /// <summary>
    /// Creates a new user asynchronously.
    /// </summary>
    public async Task<User> CreateAsync(User user)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Updates an existing user's password asynchronously.
    /// The user is identified by its userName.
    /// </summary>
    public async Task UpdateAsync(string userName, string password)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Deletes a user by its userName asynchronously.
    /// </summary>
    public async Task DeleteAsync(string userName)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves all users asynchronously.
    /// </summary>
    public async Task<IEnumerable<User>> GetAllAsync()
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }

    /// <summary>
    /// Retrieves a user by its userName asynchronously.
    /// Returns null if the user is not found.
    /// </summary>
    public async Task<User?> GetByIdAsync(string userName)
    {
        await Task.CompletedTask;
        throw new NotImplementedException();
    }
}