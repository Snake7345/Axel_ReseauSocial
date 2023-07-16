using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class ContenuDto
    {
        public Guid IdContenu { get; set; }
        public string Texte { get; set; }
        public DateTime DateCreation { get; set; }
        public CommentaireDto Commentaire { get; set; }
        public PublicationDto Publication { get; set; }
        public PvDto Pv { get; set; }
    }
}
