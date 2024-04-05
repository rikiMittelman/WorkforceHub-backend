using System.ComponentModel.DataAnnotations.Schema;
using workforceHub_backend.Core.Etities;

namespace workforceHub_backend.Models
{
    [Serializable]
    public class EmployeePostModel
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int EmployeeId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identity { get; set; }
        public DateTime StartWorkDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Status { get; set; }
        public Gender Gender { get; set; }
        public List<EmployeeRole>Roles { get; set; }

    }
}
