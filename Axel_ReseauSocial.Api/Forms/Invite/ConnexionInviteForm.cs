using System.ComponentModel.DataAnnotations;

namespace Axel_ReseauSocial.Api.Forms.Invite
{
#nullable disable
    public class ConnexionInviteForm
    {
        [Required(ErrorMessage = "Le champ Email est obligatoire.")]
        [StringLength(384, MinimumLength = 5, ErrorMessage = "Le champ Email doit avoir une longueur entre 5 et 384 caractères.")]
        [EmailAddress(ErrorMessage = "Le champ Email n'est pas une adresse email valide.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le champ Password est obligatoire.")]
        public string Passwd { get; set; }
    }
}
