﻿using AsilMedia.Domain.Entities;

namespace AsilMedia.Application.Services.Roles
{
    public interface IRoleService
    {
        public Task<Role> InsertAsync(string name);
        public Task<Role> SelectByIdAsync(long id);
        public Task<List<Role>> SelectAllAsync();
        public Task<Role> UpdateAsync(string name, long id);
        public Task<Role> DeleteAsync(long id);
    }
}
