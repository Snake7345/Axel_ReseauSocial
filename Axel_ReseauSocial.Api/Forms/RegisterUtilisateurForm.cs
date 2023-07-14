namespace Axel_ReseauSocial.Api.Forms
{
    public class RegisterUtilisateurForm
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Passwd { get; set; }
        public string Sexe { get; set; }
        public int RoleId { get; set; }
        public int LocaliteId { get; set; }
        public int TravailId { get; set; }

        public RegisterUtilisateurForm(string nom, string prenom, string email, string? passwd, string sexe, int roleId, int localiteId, int travailId)
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
