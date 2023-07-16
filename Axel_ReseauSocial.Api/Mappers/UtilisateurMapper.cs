using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class UtilisateurMapper
    {
        internal static UtilisateurDto ToUtilisateurDto(this Utilisateur utilisateur) {
            return new UtilisateurDto()
            {
                IdUtilisateur = utilisateur.IdUtilisateur,
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Email = utilisateur.Email,
                Sexe = utilisateur.Sexe,
                Date = utilisateur.Date,
                Actif = utilisateur.Actif,
                Role = new RoleDto()
                {
                    IdRole = utilisateur.Role.IdRole,
                    Denomination = utilisateur.Role.Denomination,
                },
                Localite = new LocaliteDto()
                {
                    IdLocalite = utilisateur.Localite.IdLocalite,
                    CP = utilisateur.Localite.CP,
                    Longitude = utilisateur.Localite.Longitude,
                    Latitude = utilisateur.Localite.Latitude,
                    Ville = utilisateur.Localite.Ville
                },
                Travail = new TravailDto()
                {
                    IdTravail = utilisateur.Travail.IdTravail,
                    Denomination = utilisateur.Travail.Denomination
                }
            };
        }
        internal static IEnumerable<UtilisateurDto>ToUtilisateurDto(this IEnumerable<Utilisateur> utilisateurs)
        {
            List<UtilisateurDto> result = new List<UtilisateurDto>();
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                result.Add(utilisateur.ToUtilisateurDto());
            }
            return result;
        }
    }
}
