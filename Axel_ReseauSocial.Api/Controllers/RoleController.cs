using Axel_ReseauSocial.Api.Domains.Commands.Roles;
using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Roles;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Forms.Role;
using Axel_ReseauSocial.Api.Forms.Utilisateur;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;

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

        [HttpPatch("{id}")]
        public IActionResult Update(int id, UpdateRoleForm form)
        {
            Result result = _roleRepository.Execute(new UpdateRoleCommand(id,
                form.Denomination));

            if (result.IsFailure)
            {
                return BadRequest(result.Message);
            }
            return Created("", new { message = "Le role a bien été update" });
        }
    }
}
