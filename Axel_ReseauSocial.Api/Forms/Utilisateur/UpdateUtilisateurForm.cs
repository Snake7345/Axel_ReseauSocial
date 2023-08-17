using System.ComponentModel.DataAnnotations;

namespace Axel_ReseauSocial.Api.Forms.Utilisateur
{
    public class UpdateUtilisateurForm
    {
        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        [RegularExpression(@"^[a-zA-Z\s]{2,75}$", ErrorMessage = "Le champ Nom doit contenir uniquement des lettres, avec une longueur entre 2 et 75 caractères.")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ Prénom est obligatoire.")]
        [RegularExpression(@"^[a-zA-Z\s]{2,75}$", ErrorMessage = "Le champ Prénom doit contenir uniquement des lettres, avec une longueur entre 2 et 75 caractères.")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Le champ Email est obligatoire.")]
        [StringLength(384, MinimumLength = 5, ErrorMessage = "Le champ Email doit avoir une longueur entre 5 et 384 caractères.")]
        [EmailAddress(ErrorMessage = "Le champ Email n'est pas une adresse email valide.")]
        public string Email { get; set; }
        public string? Passwd { get; set; }

        [RegularExpression("^(masculin|feminin|x)$", ErrorMessage = "La valeur du champ Sexe doit être 'masculin', 'feminin' ou 'x'.")]
        public string Sexe { get; set; }

        public int RoleId { get; set; }

        [Required(ErrorMessage = "Le champ Localite est obligatoire.")]
        public int LocaliteId { get; set; }
        [Required(ErrorMessage = "Le champ Travail est obligatoire.")]
        public int TravailId { get; set; }

        public UpdateUtilisateurForm(string nom, string prenom, string email, string? passwd, string sexe, int roleId, int localiteId, int travailId)
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
