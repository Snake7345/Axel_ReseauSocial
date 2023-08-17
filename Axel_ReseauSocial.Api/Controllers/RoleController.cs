using Axel_ReseauSocial.Api.Domains.Queries.Roles;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            return Ok(_roleRepository.Execute(new GetAllRolesQuery()).ToRoleDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Role?>> GetRole(int id)
        {
            RoleDto? role = _roleRepository.Execute(new GetOneRoleQuery(id))?.ToRoleDto();
            if (role is null)
            {
                return NotFound(new { message = "Role pas trouvé" });
            }
            return Ok(role);
        }
    }
}
