using System.ComponentModel.DataAnnotations;

namespace Axel_ReseauSocial.Api.Forms.Utilisateur
{
    public class SearchAllUtilisateurByNameForm
    {
        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        public string Nom { get; set; }

        public SearchAllUtilisateurByNameForm(string nom)
        {
            Nom = nom;
        }
    }
}
