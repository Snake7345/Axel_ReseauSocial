using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Pvs
{
    public class CreatePvCommand : ICommand
    {
        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public CreatePvCommand(Guid destinataireId, Guid destinateurId, DateTime dateCreation, string texte)
        {
            DestinataireId = destinataireId;
            DestinateurId = destinateurId;
            DateCreation = dateCreation;
            Texte = texte;
        }
    }
}
