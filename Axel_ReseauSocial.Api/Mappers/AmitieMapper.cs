using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class AmitieMapper
    {
        internal static AmitieDto ToAmitieDto(this Amitie amitie)
        {
            return new AmitieDto()
            {
                IdAmitie = amitie.IdAmitie,
                Accepte = amitie.Accepte,
                Refuse = amitie.Refuse,
                Attente = amitie.Attente,
                Destinataire = new UtilisateurDto()
                {
                    IdUtilisateur = amitie.Destinataire.IdUtilisateur,
                    Nom = amitie.Destinataire.Nom,
                    Prenom = amitie.Destinataire.Prenom,
                    Email = amitie.Destinataire.Email,
                    Sexe = amitie.Destinataire.Sexe,
                    Date = amitie.Destinataire.Date,
                    Actif = amitie.Destinataire.Actif,
                    Role = new RoleDto()
                    {
                        IdRole = amitie.Destinataire.Role.IdRole,
                        Denomination = amitie.Destinataire.Role.Denomination,
                    },
                    Localite = new LocaliteDto()
                    {
                        IdLocalite = amitie.Destinataire.Localite.IdLocalite,
                        CP = amitie.Destinataire.Localite.CP,
                        Longitude = amitie.Destinataire.Localite.Longitude,
                        Latitude = amitie.Destinataire.Localite.Latitude,
                        Ville = amitie.Destinataire.Localite.Ville
                    },
                    Travail = new TravailDto()
                    {
                        IdTravail = amitie.Destinataire.Travail.IdTravail,
                        Denomination = amitie.Destinataire.Travail.Denomination
                    }
                }
            };
        }
    }
}
