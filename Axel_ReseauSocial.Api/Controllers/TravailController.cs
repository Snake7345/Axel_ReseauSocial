using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
