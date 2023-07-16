using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class CommentaireDto
    {
        public Guid IdCommentaire { get; set; }

        public UtilisateurDto Utilisateur { get; set; }
        public PublicationDto Publication { get; set; }
    }
}
