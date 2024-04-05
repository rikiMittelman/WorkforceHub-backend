using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Services
{
    public interface IEmployeeRoleService
    {
        Task<List<EmployeeRole>> GetAllEmployeeRole();
        //Task<EmployeeRole> AddEmployeeRoleAsync(EmployeeRole employeeRole);

        //Task<EmployeeRole> UpdateEmployeeRoleAsync(int id, EmployeeRole employeeRole);

        //Task DeleteEmployeeRoleAsync(int id);

    }
}
