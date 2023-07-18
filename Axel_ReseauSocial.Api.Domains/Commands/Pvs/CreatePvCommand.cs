using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Pvs
{
    public class CreatePvCommand : ICommand
    {
        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        public CreatePvCommand(Guid destinataireId, Guid destinateurId)
        {
            DestinataireId = destinataireId;
            DestinateurId = destinateurId;
        }
    }
}
