using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class CommentaireMapper
    {
        internal static CommentaireDto ToCommentaireDto(this Commentaire commentaire)
        {
            return new CommentaireDto()
            {
                IdCommentaire = commentaire.IdCommentaire,
                Utilisateur = new UtilisateurDto()
                {
                    IdUtilisateur = commentaire.Utilisateur.IdUtilisateur,
                    Nom = commentaire.Utilisateur.Nom,
                    Prenom = commentaire.Utilisateur.Prenom,
                    Email = commentaire.Utilisateur.Email,
                    Sexe = commentaire.Utilisateur.Sexe,
                    Date = commentaire.Utilisateur.Date,
                    Actif = commentaire.Utilisateur.Actif,
                    Role = new RoleDto()
                    {
                        IdRole = commentaire.Utilisateur.Role.IdRole,
                        Denomination = commentaire.Utilisateur.Role.Denomination,
                    },
                    Localite = new LocaliteDto()
                    {
                        IdLocalite = commentaire.Utilisateur.Localite.IdLocalite,
                        CP = commentaire.Utilisateur.Localite.CP,
                        Longitude = commentaire.Utilisateur.Localite.Longitude,
                        Latitude = commentaire.Utilisateur.Localite.Latitude,
                        Ville = commentaire.Utilisateur.Localite.Ville
                    },
                    Travail = new TravailDto()
                    {
                        IdTravail = commentaire.Utilisateur.Travail.IdTravail,
                        Denomination = commentaire.Utilisateur.Travail.Denomination
                    }
                },
                DateCreation =commentaire.DateCreation,
                Texte = commentaire.Texte,
                Publication = new PublicationDto()
                {
                    IdPublication = commentaire.Publication.IdPublication,
                    Utilisateur = new UtilisateurDto()
                    {
                        IdUtilisateur = commentaire.Publication.Utilisateur.IdUtilisateur,
                        Nom = commentaire.Publication.Utilisateur.Nom,
                        Prenom = commentaire.Publication.Utilisateur.Prenom,
                        Email = commentaire.Publication.Utilisateur.Email,
                        Sexe = commentaire.Publication.Utilisateur.Sexe,
                        Date = commentaire.Publication.Utilisateur.Date,
                        Actif = commentaire.Publication.Utilisateur.Actif,
                        Role = new RoleDto()
                        {
                            IdRole = commentaire.Publication.Utilisateur.Role.IdRole,
                            Denomination = commentaire.Publication.Utilisateur.Role.Denomination,
                        },
                        Localite = new LocaliteDto()
                        {
                            IdLocalite = commentaire.Publication.Utilisateur.Localite.IdLocalite,
                            CP = commentaire.Publication.Utilisateur.Localite.CP,
                            Longitude = commentaire.Publication.Utilisateur.Localite.Longitude,
                            Latitude = commentaire.Publication.Utilisateur.Localite.Latitude,
                            Ville = commentaire.Publication.Utilisateur.Localite.Ville
                        },
                        Travail = new TravailDto()
                        {
                            IdTravail = commentaire.Publication.Utilisateur.Travail.IdTravail,
                            Denomination = commentaire.Publication.Utilisateur.Travail.Denomination
                        }
                    }
                },
            };
        }
        internal static IEnumerable<CommentaireDto> ToCommentaireDto(this IEnumerable<Commentaire> commentaires)
        {
            List<CommentaireDto> result = new List<CommentaireDto>();
            foreach (Commentaire commentaire in commentaires)
            {
                result.Add(commentaire.ToCommentaireDto());
            }
            return result;
        }
    }
}
