using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Repositories;

namespace workforceHub_backend.Data.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        //get
        public Task<List<Employee>> GetAllEmployeesAsync()
        {

            return _context.Employees.ToListAsync();
        }
        //post
        public async Task<Employee> AddEmployeeAsync(Employee employee, List<EmployeeRole> roles)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            var id = employee.EmployeeId;

            foreach (var r in roles)
            {
                r.EmployeeId = id;
            }
            _context.EmployeeRoles.AddRange(roles);
            await _context.SaveChangesAsync();

            return employee;
        }

        //put
        public async Task<Employee> UpdateEmployeeAsync(int id, Employee employee)
        {
            var temp = _context.Employees.Find(id);
            if (temp != null)
            {
                //temp.EmployeeId = employee.EmployeeId;
                temp.FirstName = employee.FirstName;
                temp.LastName = employee.LastName;
                temp.Password = employee.Password;
                temp.StartWorkDate = employee.StartWorkDate;
                temp.DateOfBirth = employee.DateOfBirth;
                temp.Status = employee.Status;
                temp.Gender = employee.Gender;
            }
            await _context.SaveChangesAsync();
            return temp;
        }
        //delete
        public async Task DeleteEmployeeAsync(int id)
        {
            var temp = _context.Employees.Find(id);
            _context.Employees.Remove(temp);
            await _context.SaveChangesAsync();

        }

       
    }
}
