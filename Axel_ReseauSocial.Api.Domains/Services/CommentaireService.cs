using Axel_ReseauSocial.Api.Domains.Commands.Amities;
using Axel_ReseauSocial.Api.Domains.Commands.Commentaires;
using Axel_ReseauSocial.Api.Domains.Queries.Commentaires;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class CommentaireService : ICommentaireRepository
    {
        private readonly ReseauSocialDbContext _context;

        public CommentaireService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Commentaire> Execute(GetAllCommentairesQuery query)
        {
            return _context.Commentaires.Include(u=>u.Utilisateur).Include(p=>p.Publication).ToList();
        }

        public Commentaire? Execute(GetOneCommentaireQuery query)
        {
            var comm = _context.Commentaires.Include(u => u.Utilisateur).Include(p => p.Publication)
                .FirstOrDefault(c => c.IdCommentaire == query.Id);

            return comm;
        }

        public Result Execute(CreateCommentaireCommand command)
        {
            try
            {
                Commentaire ObjectCommentaire = new Commentaire()
                {
                    UtilisateurId = command.UtilisateurId,
                    PublicationId = command.PublicationId,
                    DateCreation = command.DateCreation,
                    Texte = command.Texte,
                };
                _context.Commentaires.Add(ObjectCommentaire);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Commentaire)} a echouée");
            }

        }
        public Result Execute(DeleteCommentaireCommand command)
        {
            try
            {
                Commentaire? commentaire = _context.Commentaires.FirstOrDefault(c => c.IdCommentaire == command.IdCommentaire);

                if (commentaire == null)
                {
                    return Result.Failure("Le commentaire avec cet ID n'a pas été trouvé");
                }

                _context.Commentaires.Remove(commentaire); // Supprime le commentaire de la base de données
                _context.SaveChanges(); // Enregistre les modifications dans la base de données

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"La suppression de l'entité {nameof(Commentaire)} a échoué : {ex.Message}");
            }
        }
    }
}
