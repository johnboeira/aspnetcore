using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eCommerce.Domain.Features.Users;

namespace eCommerce.Application.Features.Users;

public interface IUserService
{
    /// <summary>
    /// Creates a new user asynchronously.
    /// </summary>
    Task<User> CreateAsync(User user);

    /// <summary>
    /// Updates an existing user's password asynchronously.
    /// The user is identified by its userName.
    /// </summary>
    Task UpdateAsync(string userName, string password);

    /// <summary>
    /// Deletes a user by its userName asynchronously.
    /// </summary>
    Task DeleteAsync(string userName);

    /// <summary>
    /// Retrieves all users asynchronously.
    /// </summary>
    Task<IEnumerable<User>> GetAllAsync();

    /// <summary>
    /// Retrieves a user by its userName asynchronously.
    /// Returns null if the user is not found.
    /// </summary>
    Task<User?> GetByIdAsync(string userName);
}