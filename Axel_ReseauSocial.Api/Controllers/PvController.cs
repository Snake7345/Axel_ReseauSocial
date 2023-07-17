using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
