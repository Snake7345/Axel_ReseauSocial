using Axel_ReseauSocial.Api.Domains.Queries.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Localites;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContenuController : ControllerBase
    {
        private readonly IContenuRepository _contenuRepository;

        public ContenuController(IContenuRepository contenuRepository)
        {
            _contenuRepository = contenuRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contenu>>> GetContenus()
        {
            return Ok(_contenuRepository.Execute(new GetAllContenusQuery()).ToContenuDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contenu?>> GetContenu(Guid id)
        {
            ContenuDto? loca = _contenuRepository.Execute(new GetOneContenuQuery(id))?.ToContenuDto();
            if (loca is null)
            {
                return NotFound(new { message = "Contenu pas trouvé" });
            }
            return Ok(loca);
        }
    }
}
