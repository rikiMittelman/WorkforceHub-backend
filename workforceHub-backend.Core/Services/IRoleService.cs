using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Services
{
    public interface IRoleService
    {
        Task<List<Role>> GetAllRoleAsync();
        Task<Role> AddRoleAsync(Role role);

        Task<Role> UpdateRoleAsync(int id, Role role);

        Task DeleteRoleAsync(int id);
    }
}
