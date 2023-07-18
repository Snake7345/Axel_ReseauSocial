using Axel_ReseauSocial.Api.Domains.Queries.Localites;
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
    public class LocaliteController : ControllerBase
    {
        private readonly ILocaliteRepository _localiteRepository;

        public LocaliteController(ILocaliteRepository localiteRepository)
        {
            _localiteRepository = localiteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Localite>>> GetLocalites()
        {
            return Ok(_localiteRepository.Execute(new GetAllLocalitesQuery()).ToLocaliteDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Localite?>> GetLocalite(int id)
        {
            LocaliteDto? loca = _localiteRepository.Execute(new GetOneLocaliteQuery(id))?.ToLocaliteDto();
            if (loca is null)
            {
                return NotFound(new { message = "Localite pas trouvé" });
            }
            return Ok(loca);
        }
    }
}
