using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Repositories
{
    public interface IEmployeeRoleRepository
    {
        public Task<List<EmployeeRole>> GetAllEmployeeRole();
        //public Task<EmployeeRole> AddEmployeeRoleAsync(EmployeeRole employeeRole);
        //public Task<EmployeeRole> UpdateEmployeeRoleAsync(int id, EmployeeRole employeeRole);
        //public Task DeleteEmployeeRoleAsync(int id);

    }
}
