﻿using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.DTOs;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Core
{
    public class Mapping
    {
        public static EmployeeDto MappEmployee(Employee employee,List< Role> roles, List< EmployeeRole> empRoles) {
           
            var emp = new EmployeeDto() {
                Id = employee.EmployeeId,
                DateOfBirth = employee.DateOfBirth,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Identity   = employee.Identity,
                Status = employee.Status,
                StartWorkDate = employee.StartWorkDate,
                Gender = employee.Gender,
                Roles = new List<EmployeeRoleDto>() };
            foreach (var role in empRoles)
            {
                emp.Roles.Add(MappRole(roles, role));
            }
            return emp;
        }

        public static EmployeeRoleDto MappRole(List<Role> roles, EmployeeRole empRole)
        {
            var role = roles.FirstOrDefault(r => r.RoleId == empRole.RoleId);
            if(role == null)
            {
                return null;
            }
            return new EmployeeRoleDto()
            {
                Role =new RoleDto() {RoleId = role.RoleId, RoleName = role.RoleName},
                ManagementStatus = empRole.ManagementStatus,
                EntryDate = empRole.EntryDate
            };
        }
    }


}
