using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workforceHub_backend.Core.DTOs;
using workforceHub_backend.Core.Etities;

namespace Solid.Core.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Identity { get; set; }
        [Required]
        public DateTime StartWorkDate { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Status { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public List<EmployeeRoleDto> Roles { get; set; }
    }
}
