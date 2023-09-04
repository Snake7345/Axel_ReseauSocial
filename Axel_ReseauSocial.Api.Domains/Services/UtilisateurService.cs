using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Domains.Tools;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
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

        public IEnumerable<Utilisateur?> Execute(GetSearchUtilisateurByNameQuery query)
        {
            List<Utilisateur> utilisateur =  _context.Utilisateurs
            .Include(t => t.Travail)
            .Include(r => r.Role)
            .Include(l => l.Localite)
            .ToList()
            .Where(u => u.Nom == query.Nom)
            .ToList();

            return utilisateur;
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


        public Utilisateur? Execute(GetUtilisateurByEmailAndPasswordQuery query)
        {
            var utilisateur = _context.Utilisateurs
                .Include(t => t.Travail)
                .Include(r => r.Role)
                .Include(l => l.Localite)
                .ToList()
                .FirstOrDefault(u => u.Email == query.Email && Convert.ToBase64String(query.Passwd.Hash()) == u.Passwd);

            if (utilisateur is null)
            {
                // Générez une exception pour indiquer que l'utilisateur n'a pas été trouvé
                throw new InvalidOperationException("Adresse email ou mot de passe incorrect.");
            }

            return utilisateur;
        }

        private bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != storedHash[i])
                {
                    return false; // Correspondance incorrecte
                }
            }
            return true; // Correspondance réussie
        }

        public IEnumerable<GenderCount> Execute(GetGenderCountQuery query)
        {
            var gendercount = _context.Utilisateurs.GroupBy(u => u.Sexe)
                .Select(g => new GenderCount() { Sexe = g.Key, Count = g.Count() });


            return gendercount;
        }

        public Result Execute(UpdateUtilisateurCommand command)
        {

            try
            {
                Utilisateur? utilisateur = _context.Utilisateurs.FirstOrDefault(u => u.IdUtilisateur == command.IdUtilisateur);
                if (utilisateur == null)
                {
                    throw new Exception("L'id n'a pas été trouvé");
                }

                // Mettez à jour les propriétés nécessaires de l'instance existante
                utilisateur.Nom = command.Nom;
                utilisateur.Prenom = command.Prenom;
                utilisateur.Email = command.Email;
                utilisateur.Passwd = command.Passwd;
                utilisateur.Sexe = command.Sexe;
                utilisateur.RoleId = command.RoleId;
                utilisateur.LocaliteId = command.LocaliteId;
                utilisateur.TravailId = command.TravailId;

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L'update de l'entité {nameof(Utilisateur)} a échoué");
            }


        }

        public Result Execute(DeleteUtilisateurCommand command)
        {
            try
            {
                Utilisateur? utilisateur = _context.Utilisateurs.FirstOrDefault(u => u.IdUtilisateur == command.IdUtilisateur);

                if (utilisateur == null)
                {
                    return Result.Failure("L'utilisateur avec cet ID n'a pas été trouvé");
                }

                _context.Utilisateurs.Remove(utilisateur); // Supprime l'utilisateur de la base de données
                _context.SaveChanges(); // Enregistre les modifications dans la base de données

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"La suppression de l'entité {nameof(Utilisateur)} a échoué : {ex.Message}");
            }
        }


    }
}
