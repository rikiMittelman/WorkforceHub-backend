using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Repositories
{
    public interface IRoleRepository
    {
        public Task<List<Role>> GetAllRoleAsync();
        public Task<Role> AddRoleAsync(Role role);
        public Task<Role> UpdateRoleAsync(int id, Role role);
        public Task DeleteRoleAsync(int id);

    }
}
