using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<Employee> AddEmployeeAsync(Employee employee, List<EmployeeRole>? roles);

        Task<Employee> UpdateEmployeeAsync(int id, Employee employee, List<EmployeeRole> roles);

        Task DeleteEmployeeAsync(int id);

    }
}
