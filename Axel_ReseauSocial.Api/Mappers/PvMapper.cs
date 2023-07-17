using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class PvMapper
    {
        internal static PvDto ToPvDto(this Pv pv)
        {
            return new PvDto()
            {
                IdPv = pv.IdPv,
                Destinataire = new UtilisateurDto()
                {
                    IdUtilisateur = pv.Destinataire.IdUtilisateur,
                    Nom = pv.Destinataire.Nom,
                    Prenom = pv.Destinataire.Prenom,
                    Email = pv.Destinataire.Email,
                    Sexe = pv.Destinataire.Sexe,
                    Date = pv.Destinataire.Date,
                    Actif = pv.Destinataire.Actif,
                    Role = new RoleDto()
                    {
                        IdRole = pv.Destinataire.Role.IdRole,
                        Denomination = pv.Destinataire.Role.Denomination,
                    },
                    Localite = new LocaliteDto()
                    {
                        IdLocalite = pv.Destinataire.Localite.IdLocalite,
                        CP = pv.Destinataire.Localite.CP,
                        Longitude = pv.Destinataire.Localite.Longitude,
                        Latitude = pv.Destinataire.Localite.Latitude,
                        Ville = pv.Destinataire.Localite.Ville
                    },
                    Travail = new TravailDto()
                    {
                        IdTravail = pv.Destinataire.Travail.IdTravail,
                        Denomination = pv.Destinataire.Travail.Denomination
                    }
                },
                Destinateur = new UtilisateurDto()
                {
                    IdUtilisateur = pv.Destinateur.IdUtilisateur,
                    Nom = pv.Destinateur.Nom,
                    Prenom = pv.Destinateur.Prenom,
                    Email = pv.Destinateur.Email,
                    Sexe = pv.Destinateur.Sexe,
                    Date = pv.Destinateur.Date,
                    Actif = pv.Destinateur.Actif,
                    Role = new RoleDto()
                    {
                        IdRole = pv.Destinateur.Role.IdRole,
                        Denomination = pv.Destinateur.Role.Denomination,
                    },
                    Localite = new LocaliteDto()
                    {
                        IdLocalite = pv.Destinateur.Localite.IdLocalite,
                        CP = pv.Destinateur.Localite.CP,
                        Longitude = pv.Destinateur.Localite.Longitude,
                        Latitude = pv.Destinateur.Localite.Latitude,
                        Ville = pv.Destinateur.Localite.Ville
                    },
                    Travail = new TravailDto()
                    {
                        IdTravail = pv.Destinateur.Travail.IdTravail,
                        Denomination = pv.Destinateur.Travail.Denomination
                    }
                }
            };
        }
        internal static IEnumerable<PvDto> ToPvDto(this IEnumerable<Pv> pvs)
        {
            List<PvDto> result = new List<PvDto>();
            foreach (Pv pv in pvs)
            {
                result.Add(pv.ToPvDto());
            }
            return result;
        }
    }
}
