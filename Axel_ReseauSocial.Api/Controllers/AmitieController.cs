using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
