using Axel_ReseauSocial.Api.Domains.Commands.Publications;
using Axel_ReseauSocial.Api.Domains.Queries.Publications;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class PublicationService : IPublicationRepository
    {
        private readonly ReseauSocialDbContext _context;

        public PublicationService(ReseauSocialDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Publication> Execute(GetAllPublicationsQuery query)
        {
            return _context.Publications.Include(u=>u.Utilisateur).ToList();
        }

        public Publication? Execute(GetOnePublicationQuery query)
        {
            var publication = _context.Publications.Include(u => u.Utilisateur)
                .FirstOrDefault(p => p.IdPublication == query.Id);

            return publication;
        }

        public Result Execute(CreatePublicationCommand command)
        {
            try
            {
                Publication ObjectPublication = new Publication()
                {
                    DateCreation = DateTime.Now,
                    Texte = command.Texte,
                    UtilisateurId = command.UtilisateurId,
                };
                _context.Publications.Add(ObjectPublication);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Publication)} a echouée");
            }

        }
    }
}
