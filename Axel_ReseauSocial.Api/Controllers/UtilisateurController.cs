using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Forms;
using Axel_ReseauSocial.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Axel_ReseauSocial.Api.Domains.Commands;
using Tools.Cqs.Commands;
using Axel_ReseauSocial.Api.Domains.Queries;

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
            return Ok(_utilisateurRepository.Execute(new GetAllUtilisateursQuery()));
        }

        /*// GET: api/Utilisateur/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Utilisateur>> GetUtilisateur(Guid id)
        {
            var utilisateur = await _context.Utilisateur.FindAsync(id);

            if (utilisateur == null)
            {
                return NotFound();
            }

            return utilisateur;
        }

        // POST: api/Utilisateur
        [HttpPost]
        public async Task<ActionResult<Utilisateur>> CreateUtilisateur(Utilisateur utilisateur)
        {
            _context.Utilisateur.Add(utilisateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUtilisateur", new { id = utilisateur.IdUtilisateur }, utilisateur);
        }

        // PUT: api/Utilisateur/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUtilisateur(Guid id, Utilisateur utilisateur)
        {
            if (id != utilisateur.IdUtilisateur)
            {
                return BadRequest();
            }

            _context.Entry(utilisateur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UtilisateurExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Utilisateur/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUtilisateur(Guid id)
        {
            var utilisateur = await _context.Utilisateur.FindAsync(id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            _context.Utilisateur.Remove(utilisateur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UtilisateurExists(Guid id)
        {
            return _context.Utilisateur.Any(e => e.IdUtilisateur == id);
        }
    }*/
}
}
