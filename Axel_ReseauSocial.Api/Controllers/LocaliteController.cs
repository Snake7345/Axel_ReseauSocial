using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
