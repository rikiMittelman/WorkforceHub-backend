using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workforceHub_backend.Core.Etities
{
    public enum Gender{
        Male = 1,
        Female = 2
    }
    [Serializable]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }   
        public DateTime StartWorkDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; }
        public Gender Gender { get; set; }
    }
}
