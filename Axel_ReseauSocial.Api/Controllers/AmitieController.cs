using Axel_ReseauSocial.Api.Domains.Queries.Amities;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmitieController : ControllerBase
    {
        private readonly IAmitieRepository _amitieRepository;

        public AmitieController(IAmitieRepository amitieRepository)
        {
            _amitieRepository = amitieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amitie>>> GetAmities()
        {
            return Ok(_amitieRepository.Execute(new GetAllAmitiesQuery()).ToAmitieDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Amitie?>> GetAmitie(Guid id)
        {
            AmitieDto? comm = _amitieRepository.Execute(new GetOneAmitieQuery(id))?.ToAmitieDto();
            if (comm is null)
            {
                return NotFound(new { message = "Amitie pas trouvé" });
            }
            return Ok(comm);
        }

        /*[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Result result = _amitieRepository.Execute(new DeleteAmitieCommand(id));

        if (result.IsFailure)
        {
        return BadRequest(result.Message);
        }

        return NoContent(); // Réponse 204 No Content après la suppression réussie
        }*/
    }
}
