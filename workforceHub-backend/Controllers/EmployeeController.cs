using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using workforceHub_backend.Core;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Services;
using workforceHub_backend.Models;
using workforceHub_backend.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace workforceHub_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        private readonly RoleService _roleService;
        private readonly EmployeeRoleService _empRoleService;

        public EmployeeController(EmployeeService employeeService,
            RoleService roleService,
            EmployeeRoleService empRoleService)
        {
            _employeeService = employeeService;
            _roleService = roleService;
            _empRoleService = empRoleService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var employees = await _employeeService.GetAllEmployeeAsync();
            var roles = await _roleService.GetAllRoleAsync();
            var empRoles = await _empRoleService.GetAllEmployeeRole();

            var employeesList = new List<EmployeeDto>();
            foreach (var emp in employees.Where(x => x.Status))
            {
                var employeeRoles = empRoles.Where(r => r.EmployeeId == emp.EmployeeId).ToList();
                employeesList.Add(Mapping.MappEmployee(emp, roles, employeeRoles));
            }
            return Ok(employeesList);
        }


        // GET api/<EmployeeController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeePostModel val)
        {
            var employeeToAdd = new Employee { Identity = val.Identity, FirstName = val.FirstName, LastName = val.LastName, StartWorkDate = val.StartWorkDate, DateOfBirth = val.DateOfBirth, Status = val.Status, Password = "1234", Gender = val.Gender };
            var roles = val?.Roles.Select(r =>
            new EmployeeRole() { RoleId = r.Role.RoleId, EntryDate = r.EntryDate, ManagementStatus = r.ManagementStatus }).ToList();
            var newEmployee = await _employeeService.AddEmployeeAsync(employeeToAdd, roles);
            return Ok(newEmployee);
        }


        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, EmployeePostModel val)
        {
            var employeeToAdd = new Employee { FirstName = val.FirstName, LastName = val.LastName, StartWorkDate = val.StartWorkDate, DateOfBirth = val.DateOfBirth, Status = val.Status, Password = "1234", Gender = val.Gender };
            var roles = val?.Roles.Select(r =>
            new EmployeeRole() {EmployeeId = id,  RoleId = r.Role.RoleId, EntryDate = r.EntryDate, ManagementStatus = r.ManagementStatus }).ToList();

            await _employeeService.UpdateEmployeeAsync(id, employeeToAdd, roles);

            return Ok();
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
            return Ok();
        }
    }
}
