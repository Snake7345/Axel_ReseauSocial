using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Publications
{
    public class CreatePublicationCommand : ICommand
    {
        public Guid UtilisateurId { get; set; }

        public CreatePublicationCommand(Guid utilisateurId)
        {
            UtilisateurId = utilisateurId;
        }
    }
}
