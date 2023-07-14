using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class UtilisateurDto
    {
        public Guid IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Passwd { get; set; }
        public string Sexe { get; set; }
        public DateTime Date { get; set; }
        public bool? Actif { get; set; }
        public RoleDto RoleId { get; set; }
        public LocaliteDto LocaliteId { get; set; }
        public TravailDto TravailId { get; set; }

    }
}
