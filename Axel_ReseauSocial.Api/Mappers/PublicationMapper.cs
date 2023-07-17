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
                Utilisateur = new UtilisateurDto()
                {
                    IdUtilisateur = publication.Utilisateur.IdUtilisateur,
                    Nom = publication.Utilisateur.Nom,
                    Prenom = publication.Utilisateur.Prenom,
                    Email = publication.Utilisateur.Email,
                    Sexe = publication.Utilisateur.Sexe,
                    Date = publication.Utilisateur.Date,
                    Actif = publication.Utilisateur.Actif,
                    Role = new RoleDto()
                    {
                        IdRole = publication.Utilisateur.Role.IdRole,
                        Denomination = publication.Utilisateur.Role.Denomination,
                    },
                    Localite = new LocaliteDto()
                    {
                        IdLocalite = publication.Utilisateur.Localite.IdLocalite,
                        CP = publication.Utilisateur.Localite.CP,
                        Longitude = publication.Utilisateur.Localite.Longitude,
                        Latitude = publication.Utilisateur.Localite.Latitude,
                        Ville = publication.Utilisateur.Localite.Ville
                    },
                    Travail = new TravailDto()
                    {
                        IdTravail = publication.Utilisateur.Travail.IdTravail,
                        Denomination = publication.Utilisateur.Travail.Denomination
                    }
                },
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
