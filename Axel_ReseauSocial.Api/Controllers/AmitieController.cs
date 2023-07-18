using Axel_ReseauSocial.Api.Domains.Queries.Amities;
using Axel_ReseauSocial.Api.Domains.Queries.Commentaires;
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
        public async Task<ActionResult<Amitie?>> GetCommentaire(Guid id)
        {
            AmitieDto? comm = _amitieRepository.Execute(new GetOneAmitieQuery(id))?.ToAmitieDto();
            if (comm is null)
            {
                return NotFound(new { message = "Amitie pas trouvé" });
            }
            return Ok(comm);
        }
    }
}
