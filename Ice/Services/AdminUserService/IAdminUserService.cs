﻿using Ice.Areas.Admin.Dtos.Req;
using Ice.Db.Models;

namespace Ice.Services.AdminUserService;

public interface IAdminUserService
{
    /// <summary>
    /// Gets a list of all admin users.
    /// </summary>
    /// <returns>A list of admin user identifiers.</returns>
    Task<IReadOnlyList<AdminUsers>> GetAllAdminUsersAsync(CancellationToken cancellationToken);
    
    /// <summary>
    /// Adds a new admin user.
    /// </summary>
    /// <param name="request">Add admin user request data.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>The created admin user.</returns>
    Task<AdminUsers> AddAdminUserAsync(AddAdminUserDto request, CancellationToken cancellationToken);
    
    /// <summary>
    /// Deletes an admin user by their ID.
    /// </summary>
    /// <param name="adminUserId">The ID of the admin user to delete.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAdminUserAsync(long adminUserId, CancellationToken cancellationToken);
}