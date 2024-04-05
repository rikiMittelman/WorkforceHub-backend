
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Repositories;
using workforceHub_backend.Core.Services;
using workforceHub_backend.Data.Repositories;

namespace workforceHub_backend.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        //get
        public async Task<List<Role>> GetAllRoleAsync()
        {
            return await _roleRepository.GetAllRoleAsync();
        }
        //post
        public async Task<Role> AddRoleAsync(Role role)
        {
            return await _roleRepository.AddRoleAsync(role);
        }

        //delete
        public async Task DeleteRoleAsync(int id)
        {
            await _roleRepository.DeleteRoleAsync(id);
        }

        //update
        public async Task<Role> UpdateRoleAsync(int id, Role role)
        {
            return await _roleRepository.UpdateRoleAsync(id, role);
        }
    }
}
