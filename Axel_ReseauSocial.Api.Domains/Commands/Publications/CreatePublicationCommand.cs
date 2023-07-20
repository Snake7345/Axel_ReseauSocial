using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Publications
{
    public class CreatePublicationCommand : ICommand
    {
        public Guid UtilisateurId { get; set; }

        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public CreatePublicationCommand(Guid utilisateurId, DateTime dateCreation, string texte)
        {
            UtilisateurId = utilisateurId;
            DateCreation = dateCreation;
            Texte = texte;
        }
    }
}
