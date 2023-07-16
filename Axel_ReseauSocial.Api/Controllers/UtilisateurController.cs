using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Forms;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Axel_ReseauSocial.Api.Domains.Commands;
using Tools.Cqs.Commands;
using Axel_ReseauSocial.Api.Domains.Queries;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Dtos;

namespace Axel_ReseauSocial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurController(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        [HttpPost]
        public IActionResult Register(RegisterUtilisateurForm form)
        {
            Result result = _utilisateurRepository.Execute(new RegisterUtilisateurCommand(
                form.Nom, form.Prenom, form.Email, form.Passwd, form.Sexe, form.RoleId, form.LocaliteId, form.TravailId));
            
            if(result.IsFailure)
            {
                return BadRequest(result.Message);
            }
            return Created("", new {message= "L'utilisateur a bien été créé" });
        }

        // GET: api/Utilisateur
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Utilisateur>>> GetUtilisateurs()
        {
            return Ok(_utilisateurRepository.Execute(new GetAllUtilisateursQuery()).ToUtilisateurDto());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Utilisateur?>> GetUtilisateur(Guid id)
        {
            UtilisateurDto? user = _utilisateurRepository.Execute(new GetOneUtilisateurQuery(id))?.ToUtilisateurDto();
            if(user is null)
            {
                return NotFound(new { message= "Utilisateur pas trouvé" } );
            }
            return Ok(user);
        }

    }
}
