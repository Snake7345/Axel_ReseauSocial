using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;
using Axel_ReseauSocial.Api.Mappers;
using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Forms.Utilisateur;
using Axel_ReseauSocial.Api.Forms.Invite;

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
        #region Methode terminé
        [HttpPost("registration")]
        public IActionResult Register([FromBody] RegisterUtilisateurForm form)
        {
            Result result = _utilisateurRepository.Execute(new RegisterUtilisateurCommand(
                form.Nom, form.Prenom, form.Email, form.Passwd, form.Sexe, 2, form.LocaliteId, form.TravailId));
            Console.WriteLine(result.ToString());
            if (result.IsFailure)
            {
                return BadRequest(result.Message);
            }
            return Created("", new { message = "L'utilisateur a bien été créé" });
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
            if (user is null)
            {
                return NotFound(new { message = "Utilisateur pas trouvé" });
            }
            return Ok(user);
        }

        [HttpGet("count-gender")]
        public async Task<ActionResult<IEnumerable<GenderCount>>> GetGendersCount()
        {
            return Ok(_utilisateurRepository.Execute(new GetGenderCountQuery()).ToGenderCountDto());
        }

        [HttpPatch("{id}")]
        public IActionResult Update(Guid id, UpdateUtilisateurForm form)
        {
            Result result = _utilisateurRepository.Execute(new UpdateUtilisateurCommand(id,
                form.Nom, form.Prenom, form.Email, form.Passwd, form.Sexe, 2, form.LocaliteId, form.TravailId));

            if (result.IsFailure)
            {
                return BadRequest(result.Message);
            }
            return Created("", new { message = "L'utilisateur a bien été update" });
        }

        [HttpPost("connexion")]
        public async Task<IActionResult> Connexion([FromBody] ConnexionInviteForm form)
        {
            try
            {
                Utilisateur? utilisateur = _utilisateurRepository.Execute(new GetUtilisateurByEmailAndPasswordQuery(form.Email, form.Passwd));
                return Ok(utilisateur.ToUtilisateurDto());
            }
            catch (Exception ex)
            {
                return Unauthorized(new { ex.Message });
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Result result = _utilisateurRepository.Execute(new DeleteUtilisateurCommand(id));

            if (result.IsFailure)
            {
                return BadRequest(result.Message);
            }
            return Ok(new { message = "L'utilisateur a été supprimé" });
        }


        #endregion

        [HttpPost("search")]
        public async Task<ActionResult<IEnumerable<Utilisateur>>> Search([FromBody] SearchAllUtilisateurByNameForm form)
        {
            try
            {
                IEnumerable<Utilisateur?> utilisateur = _utilisateurRepository.Execute(new GetSearchUtilisateurByNameQuery(form.Nom));

                if (utilisateur != null)
                {
                    return Ok(utilisateur.ToUtilisateurDto());
                }
                else
                {
                    return NotFound("Aucun utilisateur trouvé pour le nom spécifié.");
                }
            }
            catch (Exception ex)
            {
                return Unauthorized(new { ex.Message });
            }
        }
    }
}
