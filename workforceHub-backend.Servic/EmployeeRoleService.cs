using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Repositories;
using workforceHub_backend.Core.Services;
using workforceHub_backend.Data.Repositories;

namespace workforceHub_backend.Service
{
    public class EmployeeRoleService: IEmployeeRoleService
    {
        private readonly IEmployeeRoleRepository _employeeRoleRepository;
        public EmployeeRoleService(IEmployeeRoleRepository employeeRoleRepository)
        {
            _employeeRoleRepository= employeeRoleRepository;
        }

        //Get
        public async Task<List<EmployeeRole>> GetAllEmployeeRole()
        {
            return await _employeeRoleRepository.GetAllEmployeeRole();
        }
        //post
        //public async Task<EmployeeRole> AddEmployeeRoleAsync(EmployeeRole employeeRole)
        //{
        //    return await _employeeRoleRepository.AddEmployeeRoleAsync(employeeRole);
        //}

        ////delete
        //public async Task DeleteEmployeeRoleAsync(int id)
        //{
        //    await _employeeRoleRepository.DeleteEmployeeRoleAsync(id);
        //}

        ////update
        //public async Task<EmployeeRole> UpdateEmployeeRoleAsync(int id, EmployeeRole employeeRole)
        //{
        //    return await _employeeRoleRepository.UpdateEmployeeRoleAsync(id, employeeRole);
        //}
    }
}
