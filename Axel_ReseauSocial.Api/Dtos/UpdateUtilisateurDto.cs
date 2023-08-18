namespace Axel_ReseauSocial.Api.Dtos
{
    public class UpdateUtilisateurDto
    {
        public Guid IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Sexe { get; set; }
        public RoleDto Role { get; set; }
        public LocaliteDto Localite { get; set; }
        public TravailDto Travail { get; set; }
    }
}