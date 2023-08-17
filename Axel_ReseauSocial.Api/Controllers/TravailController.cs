using Axel_ReseauSocial.Api.Domains.Queries.Travails;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravailController : ControllerBase
    {
        private readonly ITravailRepository _travailRepository;

        public TravailController(ITravailRepository travailRepository)
        {
            _travailRepository = travailRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Travail>>> GetTravails()
        {
            return Ok(_travailRepository.Execute(new GetAllTravailsQuery()).ToTravailDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Travail?>> GetTravail(int id)
        {
            TravailDto? travail = _travailRepository.Execute(new GetOneTravailQuery(id))?.ToTravailDto();
            if (travail is null)
            {
                return NotFound(new { message = "Travail pas trouvé" });
            }
            return Ok(travail);
        }

    }
}
