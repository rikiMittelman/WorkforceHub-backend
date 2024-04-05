using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Repositories;

namespace workforceHub_backend.Data.Repositories
{
    public class EmployeeRoleRepository:IEmployeeRoleRepository
    {
        private readonly DataContext _context;
        public EmployeeRoleRepository(DataContext context)
        {
            _context = context;
        }

        public Task<List<EmployeeRole>> GetAllEmployeeRole()
        {
            return _context.EmployeeRoles.ToListAsync();
        }
        public async Task<EmployeeRole> AddEmployeeRoleAsync(EmployeeRole employeeRole)
        {
            _context.EmployeeRoles.Add(employeeRole);
            await _context.SaveChangesAsync();
            return employeeRole;
        }

        public async Task DeleteEmployeeRoleAsync(int id)
        {
            var temp = _context.EmployeeRoles.Find(id);
            _context.EmployeeRoles.Remove(temp);
            await _context.SaveChangesAsync();

        }

        public async Task<EmployeeRole> UpdateEmployeeRoleAsync(int id, EmployeeRole employeeRole)
        {
            var temp = _context.EmployeeRoles.Find(id);
            if (temp != null)
            {
                temp.EmployeeId = employeeRole.EmployeeId;
                temp.RoleId = employeeRole.RoleId;
                
            }
            await _context.SaveChangesAsync();
            return temp;
        }
    }
}
