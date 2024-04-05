using Microsoft.AspNetCore.Mvc;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace workforceHub_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeRoleController : ControllerBase
    {
        private readonly EmployeeRoleService _employeeRoleService;
        public EmployeeRoleController(EmployeeRoleService employeeRoleService)
        {
            _employeeRoleService = employeeRoleService;
        }
        // GET: api/<EmployeeRoleController>
        [HttpGet]
        public IEnumerable<EmployeeRole> Get()
        {
            return null;
            //return _employeeRoleService.GetAllEmployeeRole();
        }

        // GET api/<EmployeeRoleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeRoleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeRoleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeRoleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
