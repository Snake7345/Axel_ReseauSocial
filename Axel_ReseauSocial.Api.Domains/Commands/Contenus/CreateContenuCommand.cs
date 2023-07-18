using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Contenus
{
    public class CreateContenuCommand : ICommand
    {
        public string Texte { get; set; }

        public CreateContenuCommand(string texte)
        {
            Texte = texte;
        }
    }
}
