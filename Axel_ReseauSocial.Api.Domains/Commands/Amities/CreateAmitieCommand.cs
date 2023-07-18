using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Amities
{
    public class CreateAmitieCommand : ICommand
    {
        public bool Accepte { get; set; }
        public bool Refuse { get; set; }
        public bool? Attente { get; set; }
        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        public CreateAmitieCommand(bool accepte, bool refuse, bool? attente, Guid destinataireId, Guid destinateurId)
        {
            Accepte = accepte;
            Refuse = refuse;
            Attente = attente;
            DestinataireId = destinataireId;
            DestinateurId = destinateurId;
        }
    }
}
