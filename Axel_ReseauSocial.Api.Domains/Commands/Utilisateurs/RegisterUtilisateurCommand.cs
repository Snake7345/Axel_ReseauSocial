using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs
{
    // C'est tout ce que l'entity a besoin pour pouvoir enregistrer un user, sans les propriétés définies à l'avance par le programme
    public class RegisterUtilisateurCommand : ICommand
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Passwd { get; set; }
        public string Sexe { get; set; }
        public int RoleId { get; set; }
        public int LocaliteId { get; set; }
        public int TravailId { get; set; }

        public RegisterUtilisateurCommand(string nom, string prenom, string email, string? passwd, string sexe, int roleId, int localiteId, int travailId)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Passwd = passwd;
            Sexe = sexe;
            RoleId = roleId;
            LocaliteId = localiteId;
            TravailId = travailId;
        }
    }
}
