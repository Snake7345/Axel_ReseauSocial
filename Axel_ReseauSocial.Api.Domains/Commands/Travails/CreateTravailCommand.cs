using Tools.Cqs.Commands;


namespace Axel_ReseauSocial.Api.Domains.Commands.Travails
{
    public class CreateTravailCommand : ICommand
    {
        public string Denomination { get; set; }

        public CreateTravailCommand(string denomination)
        {
            Denomination = denomination;
        }
    }
}
