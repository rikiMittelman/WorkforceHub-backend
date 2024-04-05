using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workforceHub_backend.Core.Etities
{
    [Serializable]
    public class EmployeeRole
    {
        
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public bool ManagementStatus { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
