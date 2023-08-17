using Axel_ReseauSocial.Api.Domains.Queries.Publications;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationRepository _publicationRepository;

        public PublicationController(IPublicationRepository publicationRepository)
        {
            _publicationRepository = publicationRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Publication>>> GetPublications()
        {
            return Ok(_publicationRepository.Execute(new GetAllPublicationsQuery()).ToPublicationDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Publication?>> GetPublication(Guid id)
        {
            PublicationDto? publication = _publicationRepository.Execute(new GetOnePublicationQuery(id))?.ToPublicationDto();
            if (publication is null)
            {
                return NotFound(new { message = "Publication pas trouvé" });
            }
            return Ok(publication);
        }
    }
}
