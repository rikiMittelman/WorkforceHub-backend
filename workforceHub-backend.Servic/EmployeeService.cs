
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Repositories;
using workforceHub_backend.Core.Services;
using workforceHub_backend.Data;

namespace workforceHub_backend.Service
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly DataContext _dataContext;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //Get
        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }
        //post
        public async Task<Employee> AddEmployeeAsync(Employee employee, List<EmployeeRole>? roles)
        {
            return await _employeeRepository.AddEmployeeAsync(employee, roles);
        }

        //delete
        public async Task DeleteEmployeeAsync(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }

        //update
        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee, List<EmployeeRole> roles)
        {
            return await _employeeRepository.UpdateEmployeeAsync(id, employee, roles);
        }
    }
}
