using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Amities
{
    public class DeleteAmitieCommand : ICommand
    {
        public Guid IdAmitie { get; init; }

        public DeleteAmitieCommand(Guid idAmitie)
        {
            IdAmitie = idAmitie;
        }
    }
}
