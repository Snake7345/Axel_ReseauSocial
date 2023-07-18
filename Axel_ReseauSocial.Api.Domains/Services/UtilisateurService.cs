using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class UtilisateurService : IUtilisateurRepository
    {
        private readonly ReseauSocialDbContext _context;

        public UtilisateurService(ReseauSocialDbContext context)
        {
            _context = context;
        }

        public Result Execute(RegisterUtilisateurCommand command)
        {
            try
            {
                Utilisateur ObjectUtilisateur = new Utilisateur()
                {
                    Nom = command.Nom,
                    Prenom = command.Prenom,
                    Email = command.Email,
                    Passwd = command.Passwd,
                    Sexe = command.Sexe,
                    Date = DateTime.Now,
                    RoleId = command.RoleId,
                    LocaliteId = command.LocaliteId,
                    TravailId = command.TravailId
                };
                _context.Utilisateurs.Add(ObjectUtilisateur);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Utilisateur)} a echouée");
            }

        }

        public IEnumerable<Utilisateur> Execute(GetAllUtilisateursQuery query)
        {
            return _context.Utilisateurs.Include(t => t.Travail).Include(r => r.Role).Include(l => l.Localite).ToList();
        }

        public Utilisateur? Execute(GetOneUtilisateurQuery query)
        {
                var utilisateur = _context.Utilisateurs
                    .Include(t => t.Travail)
                    .Include(r => r.Role)
                    .Include(l => l.Localite)
                    .FirstOrDefault(u => u.IdUtilisateur == query.Id);

                return utilisateur;
        }
    }
}
