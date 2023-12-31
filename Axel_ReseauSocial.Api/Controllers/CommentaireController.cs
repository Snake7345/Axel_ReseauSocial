﻿using Axel_ReseauSocial.Api.Domains.Commands.Commentaires;
using Axel_ReseauSocial.Api.Domains.Queries.Commentaires;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commentaire>>> GetCommentaires()
        {
            return Ok(_commentaireRepository.Execute(new GetAllCommentairesQuery()).ToCommentaireDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Commentaire?>> GetCommentaire(Guid id)
        {
            CommentaireDto? comm = _commentaireRepository.Execute(new GetOneCommentaireQuery(id))?.ToCommentaireDto();
            if (comm is null)
            {
                return NotFound(new { message = "Commentaire pas trouvé" });
            }
            return Ok(comm);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Result result = _commentaireRepository.Execute(new DeleteCommentaireCommand(id));

        if (result.IsFailure)
        {
            return BadRequest(result.Message);
        }

        return NoContent();
        }
    }
}
