using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workforceHub_backend.Core.DTOs
{
    public class EmployeeRoleDto
    {
        public RoleDto Role { get; set; }
        public bool ManagementStatus { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
