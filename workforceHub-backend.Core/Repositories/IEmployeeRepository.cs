using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Task<Employee> AddEmployeeAsync(Employee employee, List<EmployeeRole> employeeRoles);
        public Task<Employee> UpdateEmployeeAsync(int id, Employee employee, List<EmployeeRole> employeeRoles);
        public Task DeleteEmployeeAsync(int id);
    }
}
