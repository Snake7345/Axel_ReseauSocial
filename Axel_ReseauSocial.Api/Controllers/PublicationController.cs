using Axel_ReseauSocial.Api.Domains.Repositories;
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
    }
}
