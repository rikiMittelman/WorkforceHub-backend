using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Models
{
    public class EmployeeGetModel
    {
        public List<EmployeeDetails> EmployeeDetails { get; set; }
       
    }
    public class EmployeeDetails
    {
        public int EmployeeID { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Identityt { get; set;}
        public DateTime StartWorkDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; }
        public Gender Gender { get; set; }
        public List<Role> Roles { get; set; }
    }
    public class Role
    {

        public int RoleDescreption { get; set; }
        public int RoleId { get; set; }
        public bool ManagementStatus { get; set; }
        public DateTime EntryDate { get; set; }
    }
}

