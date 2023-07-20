using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Commentaires
{
    public class CreateCommentaireCommand : ICommand
    {

        public Guid UtilisateurId { get; set; }
        public Guid PublicationId { get; set; }
        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public CreateCommentaireCommand(Guid utilisateurId, Guid publicationId, DateTime dateCreation, string texte)
        {
            UtilisateurId = utilisateurId;
            PublicationId = publicationId;
            DateCreation = dateCreation;
            Texte = texte;
        }

    }
}
