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
    public class RoleRepository:IRoleRepository
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }
        //get
        public Task<List<Role>> GetAllRoleAsync()
        {
            return _context.Roles.ToListAsync();

        }
        //post
        public async Task<Role> AddRoleAsync(Role role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }

        //put
        public async Task<Role> UpdateRoleAsync(int id, Role role)
        {
            var temp = _context.Roles.Find(id);
            if (temp != null)
            {
                temp.RoleName = role.RoleName;
                //temp.EntryDate= role.EntryDate;
                //temp.ManagementStatus= role.ManagementStatus;
            }
            await _context.SaveChangesAsync();
            return temp;
        }
        //delete
        public async Task DeleteRoleAsync(int id)
        {
            var temp = _context.Roles.Find(id);
            _context.Roles.Remove(temp);
            await _context.SaveChangesAsync();

        }
       
    }
}
