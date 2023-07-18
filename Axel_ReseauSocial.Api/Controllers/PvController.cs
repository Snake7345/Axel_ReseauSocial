using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
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
    public class PvController : ControllerBase
    {
        private readonly IPvRepository _pvRepository;

        public PvController(IPvRepository pvRepository)
        {
            _pvRepository = pvRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pv>>> GetPvs()
        {
            return Ok(_pvRepository.Execute(new GetAllPvsQuery()).ToPvDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pv?>> GetPv(Guid id)
        {
            PvDto? pv = _pvRepository.Execute(new GetOnePvQuery(id))?.ToPvDto();
            if (pv is null)
            {
                return NotFound(new { message = "Pv pas trouvé" });
            }
            return Ok(pv);
        }
    }
}
