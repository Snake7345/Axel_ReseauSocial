using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class AmitieDto
    {
        public Guid IdAmitie { get; set; }
        public bool? Attente { get; set; }
        public UtilisateurDto Destinataire { get; set; }
        public UtilisateurDto Destinateur { get; set; }
    }
}
