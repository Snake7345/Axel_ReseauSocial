using Axel_ReseauSocial.Api.Domains.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentaireController : ControllerBase
    {
        private readonly ICommentaireRepository _commentaireRepository;

        public CommentaireController(ICommentaireRepository commentaireRepository)
        {
            _commentaireRepository = commentaireRepository;
        }
    }
}
