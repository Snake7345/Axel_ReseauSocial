using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Commentaires
{
    public class CreateCommentaireCommand : ICommand
    {
        public Guid UtilisateurId { get; set; }
        public Guid PublicationId { get; set; }

        public CreateCommentaireCommand(Guid utilisateurId, Guid publicationId)
        {
            UtilisateurId = utilisateurId;
            PublicationId = publicationId;
        }
    }
}
