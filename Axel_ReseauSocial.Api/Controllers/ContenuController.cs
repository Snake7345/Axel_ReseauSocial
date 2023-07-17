using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
