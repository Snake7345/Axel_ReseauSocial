using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Amitie
    {
        public Guid IdAmitie { get; set; }
        public bool Accepte { get; set; }
        public bool Refuse { get; set; }
        public bool? Attente { get; set; }
        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        public virtual Utilisateur Destinataire { get; set; }
        public virtual Utilisateur Destinateur { get; set; }
    }
}
