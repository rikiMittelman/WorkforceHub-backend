using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workforceHub_backend.Core.DTOs
{
    public class EmployeeRoleDto
    {
        public string Description { get; set; }
        public int RoleId { get; set; }
        public bool ManagementStatus { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
