using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class ContenuMapper
    {
        internal static ContenuDto ToContenuDto(this Contenu contenu)
        {
            return new ContenuDto()
            {
                IdContenu = contenu.IdContenu,
                Texte = contenu.Texte,
                DateCreation = contenu.DateCreation,
                Commentaire = new CommentaireDto()
                {
                    IdCommentaire = contenu.Commentaire.IdCommentaire,
                    Utilisateur = new UtilisateurDto()
                    {
                        IdUtilisateur = contenu.Commentaire.Utilisateur.IdUtilisateur,
                        Nom = contenu.Commentaire.Utilisateur.Nom,
                        Prenom = contenu.Commentaire.Utilisateur.Prenom,
                        Email = contenu.Commentaire.Utilisateur.Email,
                        Sexe = contenu.Commentaire.Utilisateur.Sexe,
                        Date = contenu.Commentaire.Utilisateur.Date,
                        Actif = contenu.Commentaire.Utilisateur.Actif,
                        Role = new RoleDto()
                        {
                            IdRole = contenu.Commentaire.Utilisateur.Role.IdRole,
                            Denomination = contenu.Commentaire.Utilisateur.Role.Denomination,
                        },
                        Localite = new LocaliteDto()
                        {
                            IdLocalite = contenu.Commentaire.Utilisateur.Localite.IdLocalite,
                            CP = contenu.Commentaire.Utilisateur.Localite.CP,
                            Longitude = contenu.Commentaire.Utilisateur.Localite.Longitude,
                            Latitude = contenu.Commentaire.Utilisateur.Localite.Latitude,
                            Ville = contenu.Commentaire.Utilisateur.Localite.Ville
                        },
                        Travail = new TravailDto()
                        {
                            IdTravail = contenu.Commentaire.Utilisateur.Travail.IdTravail,
                            Denomination = contenu.Commentaire.Utilisateur.Travail.Denomination
                        }
                    }
                    
                },
                Publication = new PublicationDto()
                {
                    IdPublication = contenu.Publication.IdPublication,
                    Utilisateur = new UtilisateurDto()
                    {
                        IdUtilisateur = contenu.Publication.Utilisateur.IdUtilisateur,
                        Nom = contenu.Publication.Utilisateur.Nom,
                        Prenom = contenu.Publication.Utilisateur.Prenom,
                        Email = contenu.Publication.Utilisateur.Email,
                        Sexe = contenu.Publication.Utilisateur.Sexe,
                        Date = contenu.Publication.Utilisateur.Date,
                        Actif = contenu.Publication.Utilisateur.Actif,
                        Role = new RoleDto()
                        {
                            IdRole = contenu.Publication.Utilisateur.Role.IdRole,
                            Denomination = contenu.Publication.Utilisateur.Role.Denomination,
                        },
                        Localite = new LocaliteDto()
                        {
                            IdLocalite = contenu.Publication.Utilisateur.Localite.IdLocalite,
                            CP = contenu.Publication.Utilisateur.Localite.CP,
                            Longitude = contenu.Publication.Utilisateur.Localite.Longitude,
                            Latitude = contenu.Publication.Utilisateur.Localite.Latitude,
                            Ville = contenu.Publication.Utilisateur.Localite.Ville
                        },
                        Travail = new TravailDto()
                        {
                            IdTravail = contenu.Publication.Utilisateur.Travail.IdTravail,
                            Denomination = contenu.Publication.Utilisateur.Travail.Denomination
                        }
                    }
                },
                Pv = new PvDto()
                {
                    IdPv = contenu.Pv.IdPv,
                    Destinataire = new UtilisateurDto()
                    {
                        IdUtilisateur = contenu.Pv.Destinataire.IdUtilisateur,
                        Nom = contenu.Pv.Destinataire.Nom,
                        Prenom = contenu.Pv.Destinataire.Prenom,
                        Email = contenu.Pv.Destinataire.Email,
                        Sexe = contenu.Pv.Destinataire.Sexe,
                        Date = contenu.Pv.Destinataire.Date,
                        Actif = contenu.Pv.Destinataire.Actif,
                        Role = new RoleDto()
                        {
                            IdRole = contenu.Pv.Destinataire.Role.IdRole,
                            Denomination = contenu.Pv.Destinataire.Role.Denomination,
                        },
                        Localite = new LocaliteDto()
                        {
                            IdLocalite = contenu.Pv.Destinataire.Localite.IdLocalite,
                            CP = contenu.Pv.Destinataire.Localite.CP,
                            Longitude = contenu.Pv.Destinataire.Localite.Longitude,
                            Latitude = contenu.Pv.Destinataire.Localite.Latitude,
                            Ville = contenu.Pv.Destinataire.Localite.Ville
                        },
                        Travail = new TravailDto()
                        {
                            IdTravail = contenu.Pv.Destinataire.Travail.IdTravail,
                            Denomination = contenu.Pv.Destinataire.Travail.Denomination
                        }
                    },
                    Destinateur = new UtilisateurDto()
                    {
                        IdUtilisateur = contenu.Pv.Destinateur.IdUtilisateur,
                        Nom = contenu.Pv.Destinateur.Nom,
                        Prenom = contenu.Pv.Destinateur.Prenom,
                        Email = contenu.Pv.Destinateur.Email,
                        Sexe = contenu.Pv.Destinateur.Sexe,
                        Date = contenu.Pv.Destinateur.Date,
                        Actif = contenu.Pv.Destinateur.Actif,
                        Role = new RoleDto()
                        {
                            IdRole = contenu.Pv.Destinateur.Role.IdRole,
                            Denomination = contenu.Pv.Destinateur.Role.Denomination,
                        },
                        Localite = new LocaliteDto()
                        {
                            IdLocalite = contenu.Pv.Destinateur.Localite.IdLocalite,
                            CP = contenu.Pv.Destinateur.Localite.CP,
                            Longitude = contenu.Pv.Destinateur.Localite.Longitude,
                            Latitude = contenu.Pv.Destinateur.Localite.Latitude,
                            Ville = contenu.Pv.Destinateur.Localite.Ville
                        },
                        Travail = new TravailDto()
                        {
                            IdTravail = contenu.Pv.Destinateur.Travail.IdTravail,
                            Denomination = contenu.Pv.Destinateur.Travail.Denomination
                        }
                    }
                }
            };
        }
        internal static IEnumerable<LocaliteDto> ToLocaliteDto(this IEnumerable<Localite> localites)
        {
            List<LocaliteDto> result = new List<LocaliteDto>();
            foreach (Localite localite in localites)
            {
                result.Add(localite.ToLocaliteDto());
            }
            return result;
        }
    }
}
