using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Roles
{
    public class CreateRoleCommand : ICommand
    {
        public string Denomination { get; set; }

        public CreateRoleCommand(string denomination)
        {
            Denomination = denomination;
        }
    }
}
