using Microsoft.AspNetCore.Mvc;
using workforceHub_backend.Core.Etities;
using workforceHub_backend.Core.Services;
using workforceHub_backend.Models;
using workforceHub_backend.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace workforceHub_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleService _roleService;
        public RolesController(RoleService roleService)
        {
            _roleService = roleService;
        }
        // GET: api/<RolesController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var role = await _roleService.GetAllRoleAsync();
            return Ok(role);

        }
        // GET api/<RolesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<RolesController>
        [HttpPost]
        public ActionResult Post([FromBody] RolePostModel value)
        {
            //var roleToAdd=new Role { PositionName = value.PositionName,EntryDate=value.EntryDate,ManagementStatus=value.ManagementStatus };
            //var newRole=_roleService.AddRoleAsync(roleToAdd);
            //return Ok(newRole);
            return Ok();
        }
        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, RolePostModel value)
        {
            //var roleToAdd = new Role { PositionName = value.PositionName, EntryDate = value.EntryDate, ManagementStatus = value.ManagementStatus };
            //await _roleService.UpdateRoleAsync(id, roleToAdd);
            return Ok();
        }
        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _roleService.DeleteRoleAsync(id);
            return Ok();
        }
    }
}
