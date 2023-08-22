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
                Utilisateur = new UtilisateurDto()
                {
                    IdUtilisateur = publication.Utilisateur.IdUtilisateur,
                    Nom = publication.Utilisateur.Nom,
                    Prenom = publication.Utilisateur.Prenom,
                    Email = publication.Utilisateur.Email,
                    Sexe = publication.Utilisateur.Sexe,
                    Date = publication.Utilisateur.Date,
                    Actif = publication.Utilisateur.Actif,
                    Role = publication.Utilisateur.Role.ToRoleDto(),                    
                    Localite = publication.Utilisateur.Localite.ToLocaliteDto(),
                    Travail = publication.Utilisateur.Travail.ToTravailDto()
                },
            };
        }
    }
}
