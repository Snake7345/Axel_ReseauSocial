using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class PublicationMapper
    {
        internal static PublicationDto ToPublicationDto(this Publication publication)
        {
            return new PublicationDto()
            {
                IdPublication = publication.IdPublication,
                DateCreation = publication.DateCreation,
                Texte = publication.Texte,
                Utilisateur = new MinimalUtilisateurDto()
                {
                    IdUtilisateur = publication.Utilisateur.IdUtilisateur,
                    Nom = publication.Utilisateur.Nom,
                    Prenom = publication.Utilisateur.Prenom
                }
            };
        }

        internal static IEnumerable<PublicationDto> ToPublicationDto(this IEnumerable<Publication> publications)
        {
            List<PublicationDto> result = new List<PublicationDto>();
            foreach (Publication publication in publications)
            {
                result.Add(publication.ToPublicationDto());
            }

            return result;
        }
    }
}
